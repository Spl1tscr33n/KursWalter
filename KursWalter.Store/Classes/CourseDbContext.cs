﻿using System.Data.Entity;
using KursWalter.Core.Classes;

namespace KursWalter.DataAccess.Classes
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
