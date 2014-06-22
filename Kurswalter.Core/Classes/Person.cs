using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;
using KursWalter.Core.Enums;
using System.Security;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations.Schema;

namespace KursWalter.Core.Classes
{
    public class Person : IPerson
    {
        private static int _id = 1;
        
        private string _username;
        private string _firstname;
        private string _lastname;
        private string _sex;
        private string _title;
        private string _password;
        private MailAddress _emailaddress;
        private DateTime? _birthday;
        private UserArt _kindOfUser = UserArt.Guest;
        public Person()
        {
            _id++;
            ID = _id;
        }
        public int ID { get; set; }
        public Person(string username, string password, string firstname, string lastname, string title, string sex, MailAddress emailaddy, DateTime birthday, UserArt kindOfUser)
            : this()
        {
            UserName = username;
            FirstName = firstname;
            LastName = lastname;
            Sex = sex;
            Title = title;
            Password = password;
            EMailAdress = emailaddy;
            BirthDay = birthday;
            _kindOfUser = kindOfUser;
        }  

        public string UserName
        {
            get { return _username; }
            set
            {
                if (value != null)
                    _username = value;
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (value != null)
                    _password = value;
            }
        }

        //todo: dafür sorgen, das nur erlaubte namen eingetragen werden, genauso wie telefonnummer und so... entweder mit spezeillen klassen oder überprüfungen
        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if (value != null)
                    _firstname = value;
            }
        }

        public string LastName
        {
            get { return _lastname; }
            set
            {
                if (value != null)
                    _lastname = value;
            }
        }
        [NotMapped]
        public string fullName()
        {
            return _firstname + " " + _lastname;
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value != null)
                    _title = value;
            }
        }
        public string Sex
        {
            get { return _sex; }
            set
            {
                if (value != null)
                    _sex = value;
            }
        }

        public MailAddress EMailAdress
        {
            get { return _emailaddress; }
            set
            {
                if (value != null)
                    _emailaddress = value;
            }
        }

        public DateTime? BirthDay
        {
            get { return _birthday; }
            set
            {
                if (value != null)
                    _birthday = value;
            }
        }

        public UserArt kindOfUser
        {
            get { return _kindOfUser; }
        }

        public bool changeKindOfUser(UserArt client, UserArt shouldBe)
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
