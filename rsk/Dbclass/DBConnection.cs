using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace rsk.Dbclass
{
    class DBConnection
    {
        public static SqlConnection getDBConnection()
        {
            try
            {
             //  string connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|Datadirectory|\rsk_db.mdf;Integrated Security=True;User Instance=True";
                string connString = "Data Source=.\\SQLEXPRESS;Initial Catalog=rsk_db;Integrated Security=True";
              //  string connString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\rsk_db.mdf;Integrated Security=True";
                
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }


    }
}
