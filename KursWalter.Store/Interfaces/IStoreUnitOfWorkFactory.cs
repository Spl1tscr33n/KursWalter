using KursWalter.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Access.Interfaces
{
    public interface ICourseUnitOfWorkFactory
    {
        ICourseUnitOfWork Create();
    }
}
