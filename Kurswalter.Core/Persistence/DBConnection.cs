using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;

namespace KursWalter.Persistence
{
    public class DBConnection : IDBConnection
    {
        MySqlConnection conn = null;
        protected string connectionString;
        private bool _isConnected = false;

        public bool IsConnected
        {
            get
            {
                return _isConnected;
            }
        }
        public DBConnection(string host, string db_name, string user, string password)
        {
            if ((host == null) || (db_name == null) || (user == null) || (password == null))
            {
                throw new ArgumentNullException();
            }
            connectionString = "Server=" + host + ";Database=" + db_name + ";Uid=" + user + ";Pwd=" + password + ";";
        }

        public string connect()
        {
            string ret = "";
            conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                _isConnected = true;
                ret = "Mysql version: " + conn.ServerVersion;
            }
            catch (MySqlException ex)
            {
                ret += ex.Message;
                conn.Close();
                conn.Dispose();
            }
            return ret;
        }

        public void disconnect()
        {
            _isConnected = false;
            conn.Close();
            conn.Dispose();
        }
    }
}
