using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace projektFeladat_WPF.Common
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        public int? ID { get; private set; } 

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

       public void SetId(int id)
        {
            if (ID==null)
            {
                ID = id;
                //MessageBox.Show($"ID has been set:{ID}");
            }
        }
    }
}
