using KursWalter.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Access.Classes
{
    public class CourseUnitOfWorkFactory : ICourseUnitOfWork
    {

        public IRepository<Core.Classes.Person> Persons
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<Core.Classes.Course> Courses
        {
            get { throw new NotImplementedException(); }
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ICourseUnitOfWork Create()
        {
            throw new NotImplementedException();
        }
    }
}
