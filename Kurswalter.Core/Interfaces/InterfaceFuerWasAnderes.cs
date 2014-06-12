using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;
using MySql.Data.MySqlClient;

namespace Kurswalter.Core.Interfaces
{
    interface InterfaceFuerWasAnderes
    {
        MySqlConnection Connection { get; }
        bool IsConnected { get; }
        string ErrorMessage { get; }
        //DBConnection(string host, string db_name, string user, string password);
        bool Connect(string host, string db_name, string user, string password);
        void Disconnect();
    }
}
