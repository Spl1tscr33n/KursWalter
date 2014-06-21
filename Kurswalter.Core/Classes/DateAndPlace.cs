using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;

namespace KursWalter.Core.Structs
{
    public class DateAndPlace : IDateAndPlace
    {
        private DateTime _date;
        private string _place;
        public DateTime? Date
        {
            get { return _date; }
        }
        
        public string Place
        {
            get { return _place; }
        }
        
        public DateAndPlace(DateTime time, string place)
        {
            if (time == null) throw new ArgumentNullException("NoDateEnterd");
            if (place == null) throw new ArgumentNullException("NoPlaceEnterd");

            _date = time;
            _place = place;
        }

        public bool Equals ( IDateAndPlace other)
        {
            bool retVal = false;
            if (_date == other.Date && _place == other.Place)
                retVal = true;


            return retVal;
        }
    }
}
