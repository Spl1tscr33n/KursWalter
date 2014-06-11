using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;

namespace Kurswalter.Core.Classes
{
    public class Course : ICourse
    {
        private string _name;
        public Course (string Name)
        {
            _name = Name;
        }
        public string CourseName
        {
            get { return _name; }
        }
        private List<IDateAndPlace> _happenings;  //plan ist sozusagen jedes mal wenn ein kurs ist diesen mit seinem platz einzutragen
        public List<IDateAndPlace> Happenings
        {
            get { return _happenings; }
        }
        public void addHappening (IDateAndPlace newDate )
        {
            if (newDate == null) throw new ArgumentNullException("NoDateEntered");
            _happenings.Add(newDate);
        }
        public bool AreOverlapping ( ICourse other)
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
