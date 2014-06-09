using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Persistence
{
    class DBConnection
    {
        MySqlConnection conn = null;
        protected string connectionString; 
        public DBConnection(string host, string db_name, string user, string password)
        {
            if ((host == null) || (db_name == null) || (user == null) || (password == null))
            {
                throw new ArgumentNullException();
            }
            connectionString = "Server=" + host + ";Database=" + db_name + ";Uid=" + user + ";Pwd=" + password + ";";
        }

        public bool connect()
        {
            conn = new MySqlConnection(connectionString);
            if (conn == null)
                return false;
            else
            {
                conn.Open();
                return true;
            }
            try
            {
                //Todo: Ricardo Textbox add
                Console.WriteLine("\n Mysql version: {0}", conn.ServerVersion);
            }
            catch (MySqlException ex)
            {
                //Todo: Ricardo Textbox add
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
