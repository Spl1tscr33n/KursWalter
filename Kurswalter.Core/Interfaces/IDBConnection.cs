using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;

namespace Kurswalter.Core.Interfaces
{
    public interface IDBConnection
    {
        bool IsConnected { get; }
        string ErrorMessage { get; }
        bool Connect(string host, string db_name, string user, string password);
        void disconnect();
    }
}
