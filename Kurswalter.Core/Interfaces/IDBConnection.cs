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
        bool IsConnected{get;}

        bool connect();

        void disconnect();
    }
}
