using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;
using Kurswalter.Core.Enums;
using System.Security;
using System.Net.Mail;

namespace Kurswalter.Core.Classes
{
    public class Person : IPerson
    {
        //private static int IDGEN = 1; //brauch ma nicht so viel ich weis
        private readonly int _id;
        public int ID
        {
            get { return _id; }
        }
        public string TelNum { get; set; }

        public Person()
        {
            //_id = IDGEN;
            //IDGEN++;
        }

        public string Username
        {
            get { return Username; }
            set
            {
                if (value != null)
                    Username = value;
            }
        }

        //todo: dafür sorgen, das nur erlaubte namen eingetragen werden, genauso wie telefonnummer und so... entweder mit spezeillen klassen oder überprüfungen
        public string FirstName
        {
            get { return FirstName; }
            set
            {
                if (value != null)
                    FirstName = value;
            }
        }

        public string SecondName
        {
            get { return SecondName; }
            set
            {
                if (value != null)
                    SecondName = value;
            }
        }
        public string fullName()
        {
            return FirstName + " " + SecondName;
        }

        public string Title
        {
            get { return Title; }
            set
            {
                if (value != null)
                    Title = value;
            }
        }

        //hilfe für wfp http://stackoverflow.com/questions/2978348/wpf-password-box-into-a-securestring-in-c-sharp
        public SecureString Password
        {
            get { return Password; }
            set
            {
                if (value != null)
                    Password = value;
            }
        }

        public MailAddress EMailAdress       //todo: vllt über email-klasse
        {
            get { return EMailAdress; }
            set
            {
                if (value != null)
                    EMailAdress = value;
            }
        }

        public DateTime? BirthDay
        {
            get { return BirthDay; }
            set 
            {
                if (value != null)
                    BirthDay = value;
            }
        }
        
        private UserArt _kindOfUser = UserArt.Guest;
        public UserArt kindOfUser     
        {
            get { return _kindOfUser; }
        }

        public bool chanceKindOfUser (UserArt client, UserArt shouldBe)
        {
            bool retVal;
            if (client == UserArt.Admin)
            {
                _kindOfUser = shouldBe;
                retVal = true;
            }
            else
            {
                retVal = false;
            }
            return retVal;
        }

        private List<ICourse> _personalCourses;
        public List<ICourse> Courses
        {
            get { return _personalCourses; }
        }
        public void AddCourse (ICourse newCourse)
        {
            if (newCourse == null)
                throw new ArgumentNullException("NewCourse");
            else
                _personalCourses.Add(newCourse);
        }
    }
}
