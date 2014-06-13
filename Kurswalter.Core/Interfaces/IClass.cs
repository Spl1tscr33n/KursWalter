using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurswalter.Core.Interfaces
{
    public interface IClass
    {
        int ID{get;}

        string ClassName{get;}
        List<IDateAndPlace> Happenings{get;}
        void addHappening(IDateAndPlace newDate);

        bool AreOverlapping(IClass other);

        string ShortContent{get;set;}

        string LongContent{get; set;}

        string Dozent{get;}


        //vllt auch weglassen da über linq befhele filter bar
        List<IPerson> Member{get; }
        void AddMember(IPerson person);
    }
}
