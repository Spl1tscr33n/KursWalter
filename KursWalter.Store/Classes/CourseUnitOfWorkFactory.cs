using KursWalter.DataAccess.Interfaces;
using KursWalter.DataAccess.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.DataAccess.Classes
{
    public class CourseUnitOfWorkFactory : ICourseUnitOfWorkFactory
    {

        public ICourseUnitOfWork Create()
        {
            var dbContext = new CourseDbContext();
            var unitOfWorkAdapter = new CourseDbContextAdapter(dbContext);
            return unitOfWorkAdapter;
        }
    }
}
