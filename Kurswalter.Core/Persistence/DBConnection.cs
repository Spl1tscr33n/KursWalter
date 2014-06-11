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
        private MySqlConnection _connection = null;
        protected string _connectionString;
        private bool _isConnected = false;
        private string _ErrorMessage = null;

        public bool IsConnected { get; }
        public string ErrorMessage { get; }
        public MySqlConnection Connection { get; }

        public bool Connect(string host, string db_name, string user, string password)
        {
            if ((host == null) || (db_name == null) || (user == null) || (password == null))
            {
                throw new ArgumentNullException();
            }
            _connection = new MySqlConnection("Server=" + host + ";Database=" + db_name + ";Uid=" + user + ";Pwd=" + password + ";");
            try
            {
                _connection.Open();
                if (_connection.Ping())
                {
                    _isConnected = true;
                }
            }
            catch (MySqlException ex)
            {
                _ErrorMessage = ex.Message;
                _isConnected = false;
                _connection.Close();
                _connection.Dispose();
                return false;
            }
            return true;
        }

        public void disconnect()
        {
            _isConnected = false;
            _connection.Close();
            _connection.Dispose();
        }
    }
}
