using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;

namespace KursWalter.Persistence
{
    class DBConnection : IDBConnection
    {
        protected MySqlConnection _conn = null;
        protected string _connectionString = null;
        private bool _isConnected = false;
        private string _errorMessage = null;
        public bool IsConnected { get; }
        public string ErrorMessage { get; }
        public DBConnection() { }
        public DBConnection(string host, string db_name, string user, string password)
        {
            if ((host == null) || (db_name == null) || (user == null) || (password == null))
            {
                throw new ArgumentNullException();
            }
            _connectionString = "Server=" + host + ";Database=" + db_name + ";Uid=" + user + ";Pwd=" + password + ";";
        }
        public bool Connect(string host, string db_name, string user, string password)
        {
            if ((host == null) || (db_name == null) || (user == null) || (password == null))
            {
                throw new ArgumentNullException();
            }
            return Connect("Server=" + host + ";Database=" + db_name + ";Uid=" + user + ";Pwd=" + password + ";");
        }

        public bool Connect()
        {
            if (_connectionString == null)
                throw new ArgumentNullException();
            else
                return Connect(_connectionString);
        }
        public bool Connect(string ConnectionString)
        {
            if (_connectionString == null)
                throw new ArgumentNullException();
            _conn = new MySqlConnection(ConnectionString);
            try
            {
                _conn.Open();
                if (_conn.Ping())
                {
                    _isConnected = true;
                }

            }
            catch (MySqlException ex)
            {
                _isConnected = false;
                _conn.Close();
                _conn.Dispose();
                _errorMessage = ex.Message;
                return false;
            }
            return true;
        }
        public void disconnect()
        {
            _isConnected = false;
            _conn.Close();
            _conn.Dispose();
        }
    }
}
