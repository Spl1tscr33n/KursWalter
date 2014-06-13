using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Enums;
using System.Net.Mail;

namespace Kurswalter.Core.Interfaces
{
    public interface IPerson
    {
         string TelNum { get; set; }
         string FirstName { get; set; }
         string SecondName { get; set; }
         string fullName();
         DateTime? BirthDay { get; set; }
         MailAddress EMailAdress { get; set; }
         UserArt kindOfUser { get;}
         bool chanceKindOfUser(UserArt client, UserArt shouldBe);
         List<ICourse> Courses { get; }
         void AddCourse(ICourse newCourse);
    }
}
