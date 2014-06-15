using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;
using MySql.Data.MySqlClient;

namespace KursWalter.Core.Interfaces
{
    public interface IDBConnection
    {
        bool IsConnected{get;}
        MySqlConnection Connection { get; }
        string ErrorMessage { get; }

        bool Connect(string host, string db_name, string port, string user, string password);

        void Disconnect();
    }
}
