using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Core.Interfaces
{
    public interface IModifyUser
    {
        string ErrorMessage { get; }
        bool AddUser( IPerson person );
        bool DeleteUser( IPerson person );
        bool EditUser(IPerson person );
    }
}
