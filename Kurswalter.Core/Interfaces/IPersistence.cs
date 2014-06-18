using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Core.Interfaces
{
    public interface IPersistence
    {
        bool Delete(IPersistenceItem item);
        bool Add(IPersistenceItem item);
        IPersistenceItem GetItemByID(int ID);
    }
}
