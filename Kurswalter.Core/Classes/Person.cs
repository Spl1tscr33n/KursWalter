using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;
using KursWalter.Core.Enums;
using System.Security;
using System.Net.Mail;

namespace KursWalter.Core.Classes
{
    public class Person : IPerson
    {
        private static int _id = 1;
        public int ID { get; set; }
        private string _UserName { get; set; }
        private string _FirstName { get; set; }
        private string _LastName { get; set; }
        private string _Sex { get; set; }
        private string _Title { get; set; }
        private string _Password { get; set; }
        private MailAddress _EMailAdress { get; set; }
        private DateTime? _BirthDay { get; set; }
        private UserArt _kindOfUser = UserArt.Guest;
        public Person()
        {
            _id++;
            ID = _id;
        }

        public Person(string username, string firstname, string lastname, string sex, string title, string password, MailAddress emailaddy, DateTime date)
            : this()
        {
            UserName = username;
            FirstName = firstname;
            LastName = lastname;
            Sex = sex;
            Title = title;
            Password = password;
            EMailAdress = emailaddy;
            BirthDay = date;
        }

        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (value != null)
                    _UserName = value;
            }
        }

        //todo: dafür sorgen, das nur erlaubte namen eingetragen werden, genauso wie telefonnummer und so... entweder mit spezeillen klassen oder überprüfungen
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                if (value != null)
                    _FirstName = value;
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                if (value != null)
                    _LastName = value;
            }
        }
        public string fullName()
        {
            return FirstName + " " + LastName;
        }
        public string Sex
        {
            get { return _Sex; }
            set
            {
                if (value != null)
                    _Sex = value;
            }
        }

        public string Title
        {
            get { return _Title; }
            set
            {
                if (value != null)
                    _Title = value;
            }
        }

        //hilfe für wfp http://stackoverflow.com/questions/2978348/wpf-password-box-into-a-securestring-in-c-sharp
        public string Password
        {
            get { return _Password; }
            set
            {
                if (value != null)
                    _Password = value;
            }
        }

        public MailAddress EMailAdress
        {
            get { return _EMailAdress; }
            set
            {
                if (value != null)
                    _EMailAdress = value;
            }
        }

        public DateTime? BirthDay
        {
            get { return _BirthDay; }
            set
            {
                if (value != null)
                    _BirthDay = value;
            }
        }


        public UserArt kindOfUser
        {
            get { return _kindOfUser; }
        }

        public bool chanceKindOfUser(UserArt client, UserArt shouldBe)
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
        public void AddCourse(ICourse newCourse)
        {
            if (newCourse == null)
                throw new ArgumentNullException("NewCourse");
            else
                _personalCourses.Add(newCourse);
        }
    }
}
