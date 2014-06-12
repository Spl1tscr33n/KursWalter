using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Enums;
using System.Security;
using System.Net.Mail;

namespace Kurswalter.Core.Interfaces
{
    public interface IPerson
    {
        int ID {get; }

        string Username{get; set;}

        string FirstName{get; set;}

        string SecondName{get; set;}
        string fullName();

        string Title{get; set;}

        //hilfe für wfp http://stackoverflow.com/questions/2978348/wpf-password-box-into-a-securestring-in-c-sharp
        SecureString Password{get; set;}

        MailAddress EMailAdress{get; set;}

        DateTime? BirthDay{get; set;}
        
        UserArt kindOfUser {get;}

        bool chanceKindOfUser(UserArt client, UserArt shouldBe);

        List<ICourse> Courses{ get; }
        void AddCourse(ICourse newCourse);
    }
}
