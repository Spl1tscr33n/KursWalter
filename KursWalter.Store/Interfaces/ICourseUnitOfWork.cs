using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Classes;
using KursWalter.DataAccess.Interfaces;

namespace KursWalter.DataAccess.Interfaces
{
    public interface ICourseUnitOfWork
    {
        IRepository<Person> Persons { get; }
        IRepository<Course> Courses { get; }
    }
}
