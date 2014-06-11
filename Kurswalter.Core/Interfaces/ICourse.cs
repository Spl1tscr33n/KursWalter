using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurswalter.Core.Interfaces
{
    public interface ICourse
    {
        public string CourseName{ get ;}
        public List<IDateAndPlace> Happenings { get; }
        public void addHappening(IDateAndPlace newDate);
        public bool AreOverlapping(ICourse other);
    }
}
