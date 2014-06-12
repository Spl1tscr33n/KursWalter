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
        bool _isConnected { get; }
        //DBConnection(string host, string db_name, string user, string password);
        string connect();
    }
}
