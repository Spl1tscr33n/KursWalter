using System.Data.Entity;
using KursWalter.Core.Classes;

namespace KursWalter.DataAccess.Classes
{
    public class StoreDbContext : DbContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<Course> Courses { get; set; }
    }
}
