﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;

namespace Kurswalter.Core.Classes
{
    public class Class : IClass
    {
        private string _dozent;
        private List<IPerson> _member;
        public int ID
        {
            get { return ID; }
        }

        private string _name;

        public string ClassName
        {
            get { return _name; }
        }

        public Class (string Name, string dozent)
        {
            _name = Name;
            _dozent = dozent;
        }

        private List<IDateAndPlace> _happenings;  //plan ist sozusagen jedes mal wenn ein kurs ist diesen mit seinem platz einzutragen
        public List<IDateAndPlace> Happenings
        {
            get { return _happenings; }
        }
        public void addHappening(IDateAndPlace newDate)
        {
            if (newDate == null) throw new ArgumentNullException("NoDateEntered");
            _happenings.Add(newDate);
        }

        public bool AreOverlapping ( IClass other)
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

        public string Dozent
        {
            get { return _dozent; }
        }


        //vllt auch weglassen da über linq befhele filter bar
        public List<IPerson> Member
        {
            get { return _member; }
        }
        public void AddMember (IPerson person)
        {
            _member.Add(person);
        }
    }
}
