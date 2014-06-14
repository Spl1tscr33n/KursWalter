using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Enums;
using System.Net.Mail;
using System.Security;

namespace Kurswalter.Core.Interfaces
{
    public interface IPerson
    {
        int ID { get; set; }        
        string UserName { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string fullName();
        DateTime? BirthDay { get; set; }
        MailAddress EMailAdress { get; set; }
        UserArt kindOfUser { get;}
        bool chanceKindOfUser(UserArt client, UserArt shouldBe);
        List<ICourse> Courses { get; }
        void AddCourse(ICourse newCourse);
        string Sex { get; set; }
        string Title { get; set; }
        string Password { get; set; }
         
    }
}
