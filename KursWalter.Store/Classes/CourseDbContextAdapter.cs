using KursWalter.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;
using KursWalter.Core.Classes;

namespace KursWalter.DataAccess.Classes
{
    class CourseDbContextAdapter : ICourseUnitOfWork
    {
        private readonly CourseDbContext _courseDbContext;
        private readonly IRepository<Person> _persons;
        private readonly IRepository<Course> _courses;

        public CourseDbContextAdapter(CourseDbContext courseDbContext)
        {
            _courseDbContext = courseDbContext;
            _persons = new DbSetRepositoryAdapter<Person>(courseDbContext.Persons);
            _courses = new DbSetRepositoryAdapter<Course>(courseDbContext.Courses);
        }

        public void SaveChanges()
        {
            _courseDbContext.SaveChanges();
        }

        public IRepository<Person> Persons
        {
            get { return _persons; }
        }
        public IRepository<Course> Courses
        {
            get { return _courses; }
        }
        public void Dispose()
        {
            _courseDbContext.Dispose();
        }
    }
}
