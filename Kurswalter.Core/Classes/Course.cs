using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;

namespace KursWalter.Core.Classes
{
    public class Course : ICourse
    {
        private static int _id = 1;
        private string _dozent;
        private List<IPerson> _member = new List<IPerson>();
        private DateTime _creationdate;
        private string _name;
        private List<IDateAndPlace> _happenings = new List<IDateAndPlace>();

        public int ID { get; set; }
        public DateTime CreationDate { get; private set; }

        public string CourseName
        {
            get { return _name; }
        }
        public Course (string Name, string dozent)
        {
            _name = Name;
            _dozent = dozent;
            _creationdate = DateTime.Now;
            _id++;
            ID = _id;

        }

        //plan ist sozusagen jedes mal wenn ein kurs ist diesen mit seinem platz einzutragen
          
        public List<IDateAndPlace> Happenings
        {
            get { return _happenings; }
        }

        public void addHappening(IDateAndPlace newDate)
        {
            if (newDate == null) throw new ArgumentNullException("NoDateEntered");
            _happenings.Add(newDate);
        }


        public string ShortContent
        {
            get { return ShortContent; }
            set
            {
                if (value != null)
                    ShortContent = value;
            }
        }

        public string LongContent
        {
            get { return LongContent; }
            set
            {
                if (value != null)
                    LongContent = value;
            }
        }

        public string Reader
        {
            get { return _dozent; }
        }


        //vllt auch weglassen da über linq befhele filter bar
        public List<IPerson> Participants
        {
            get { return _member; }
        }
        public void AddMember (IPerson person)
        {
            _member.Add(person);
        }

        // functions
        public bool AreOverlapping(ICourse other)
        {
            bool retVal = false;
            foreach (var hap in this._happenings)
            {
                foreach (var othHap in other.Happenings)
                {
                    if (hap == othHap)
                        retVal = true;
                }
            }
            return retVal;
        }
    }
}
