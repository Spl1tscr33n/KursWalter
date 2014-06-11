using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Structs;

namespace Kurswalter.Core.Interfaces
{
    public interface IDateAndPlace
    {
        public DateTime? Date{ get; }
        public string Place{ get;}
        public bool Equals(DateAndPlace other);
    }
}
