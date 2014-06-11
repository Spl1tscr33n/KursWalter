using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurswalter.Core.Interfaces
{
    public interface ICourse
    {
        string CourseName{ get ;}
        List<IDateAndPlace> Happenings { get; }
        void addHappening(IDateAndPlace newDate);
        bool AreOverlapping(ICourse other);
    }
}
