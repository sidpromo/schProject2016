
namespace projektFeladat_WPF.Common
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private bool idHasBeenSet = false;
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
            if (!idHasBeenSet)
            {
                ID = id;
                idHasBeenSet = true;
                //MessageBox.Show($"ID has been set:{ID}");
            }
        }
    }
}
