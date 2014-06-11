using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Enums;

namespace Kurswalter.Core.Interfaces
{
    public interface IPerson
    {
        public string TelNum { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string fullName();
        public DateTime? BirthDay { get; set; }
        public string EMailAdress { get; set; }
        public string kindOfUser { get;}
        public bool chanceKindOfUser(UserArt client, UserArt shouldBe);
        public List<ICourse> Courses { get; }
        public void AddCourse(ICourse newCourse);
    }
}
