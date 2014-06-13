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
         DateTime? Date{ get; }
         string Place{ get;}
         bool Equals(IDateAndPlace other);
    }
}
