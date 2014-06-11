using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;
using Kurswalter.Core.Enums;

namespace Kurswalter.Core.Classes
{
    public class Person : IPerson
    {
        public string Title
        {
            get { return Title; }
            set
            {
                if (value != null)
                    Title = value;
            }
        }
        public string TelNum
        {
            get { return TelNum; }
            set
            {
                if (value != null)
                    TelNum = value;
            }
        }
        public Person ()
        {
            _id = IDGEN;
            IDGEN++;

        }
        private static int IDGEN = 1;
        private readonly int _id;
        public int ID
        {
            get { return _id; }
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
        public string fullName ()
        {
            return FirstName + " " + SecondName;
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
        public string EMailAdress       //todo: vllt über email-klasse
        {
            get { return EMailAdress;}
            set
            {
                if (value != null)
                    EMailAdress = value;
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
