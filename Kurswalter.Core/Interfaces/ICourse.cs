using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Core.Interfaces
{
    public interface ICourse
    {
        int ID { get; set; }
        string CourseName{get;}
        List<IDateAndPlace> Happenings{get;}
        void addHappening(IDateAndPlace newDate);

        bool AreOverlapping(ICourse other);

        string ShortContent{get;set;}

        string LongContent{get; set;}

        string Reader{get;}

        //vllt auch weglassen da über linq befhele filter bar
        List<IPerson> Participants {get; }
        void AddMember(IPerson person);
    }
}
