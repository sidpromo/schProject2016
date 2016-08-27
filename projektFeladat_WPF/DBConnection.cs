using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace projektFeladat_WPF
{
    /// <summary>
    /// SQL kapcsolat létrehozásáért felelős osztály, connentrion stringet meg kell adni még!!!!
    /// </summary>
    public class DBConnection
    {
        public SqlConnection con;
        public string connStr;
        public void Connection()
        {
            connStr = "";  //TODO: connection string beírása 
            con = new SqlConnection(connStr);
            con.Open();
            
        }
        
    }
}
