using KursWalter.DataAccess.Interfaces;
using KursWalter.DataAccess.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KursWalter.DataAccess.Classes
{
    public class CourseUnitOfWorkFactory : ICourseUnitOfWorkFactory
    {
        private string _connectionString;
        public CourseUnitOfWorkFactory(string host, string db_name, string port, string user, string password)
        {
            if ((host == null) || (db_name == null) || (user == null) || (password == null))
            {
                throw new ArgumentNullException();
            }
            _connectionString = "Server=" + host + ";Database=" + db_name + ";Uid=" + user + ";Pwd=" + password + ";";
            if(port != null)
                _connectionString += "Port=" + port + ";";
        }

        public ICourseUnitOfWork Create()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<CourseDbContext>());
            CourseDbContext dbContext = new CourseDbContext(_connectionString);
            CourseDbContextAdapter unitOfWorkAdapter = new CourseDbContextAdapter(dbContext);
            return unitOfWorkAdapter;
        }
    }
}
