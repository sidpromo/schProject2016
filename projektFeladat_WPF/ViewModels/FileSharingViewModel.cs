using projektFeladat_WPF.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WinSCP;

namespace projektFeladat_WPF.ViewModels
{
    public class FileSharingViewModel : Bindable
    {
        public static class KnownFolder
        {
            public static readonly Guid Downloads = new Guid("374DE290-123F-4565-9164-39C4925E467B");
        }

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags, IntPtr hToken, out string pszPath);

        private List<RemoteFileInfo> fileList;

        public List<RemoteFileInfo> FileList
        {
            get { return fileList; }
            set { fileList = value; OnPropertyChanged(); }
        }

        private RemoteFileInfo selectedFile;

        public RemoteFileInfo SelectdFile
        {
            get { return selectedFile; }
            set { selectedFile = value; OnPropertyChanged(); }
        }
        public ICommand DownloadCommand { get; private set; }
        public ICommand UploadCommand { get; private set; }

        SessionOptions sessionOptions = new SessionOptions
        {
            Protocol = Protocol.Sftp,
            HostName = "home.sch.bme.hu",
            UserName = "sidpromo",
            Password = System.IO.File.ReadAllText(@"C:\auth.txt"),
            SshHostKeyFingerprint = "ssh-rsa 2048 ce:35:d7:6b:73:c4:94:66:c3:21:f2:cf:59:6c:0b:80"
        };

        public FileSharingViewModel()
        {
            List();
            DownloadCommand = new RelayCommand(Download);
            UploadCommand = new RelayCommand(UpLoad); 
        }
        void List()
        {
            FileList = new List<RemoteFileInfo>();
            using (Session session = new Session())
            {
                //Connect
                session.Open(sessionOptions);

                //list directory
                RemoteDirectoryInfo subDirs = session.ListDirectory("/home/sidpromo/public/");
                foreach (RemoteFileInfo item in subDirs.Files)
                {
                    //FileList.Add(new MyFile(item));
                    if (item.Name != "." && item.Name != "..")
                    {
                        FileList.Add(item);
                    }
                }
            }
        }

        void Download()
        {

            if (SelectdFile != null)
            {
                using (Session session = new Session())
                {
                    //Download folder
                    string downloads;
                    SHGetKnownFolderPath(KnownFolder.Downloads, 0, IntPtr.Zero, out downloads);
                    StringBuilder sb = new StringBuilder();
                    sb.Append(downloads); sb.Append("\\");

                    //Connect
                    session.Open(sessionOptions);

                    //Upload files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;

                    transferResult = session.GetFiles(SelectdFile.FullName, sb.ToString(), false, transferOptions);

                    transferResult.Check();
                    foreach (TransferEventArgs transfer in transferResult.Transfers)
                    {
                        MessageBox.Show($"Download of {transfer.FileName} succeeded");
                    }
                    Process.Start(downloads);
                }
            }
        }

        void UpLoad()
        {
            using (Session session = new Session())
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

                // Set filter for file extension and default file extension 
                dlg.DefaultExt = ".pdf";
                dlg.Filter = "PDF Files|*.pdf";
                //dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

                // Display OpenFileDialog by calling ShowDialog method 
                Nullable<bool> result = dlg.ShowDialog();

                // Get the selected file name and display in a TextBox 
                if (result == true)
                {
                    // Open document 
                    string filename = dlg.FileName;
                    session.Open(sessionOptions);

                    // Upload files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;
                    transferResult = session.PutFiles(filename, "/home/sidpromo/public/", false, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Print results
                    foreach (TransferEventArgs transfer in transferResult.Transfers)
                    {
                        Console.WriteLine($"Upload of {transfer.FileName} succeeded");
                    }
                }
            }
            List();
        }
    }
}
