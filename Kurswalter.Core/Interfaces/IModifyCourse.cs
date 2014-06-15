using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Core.Interfaces
{
    interface IModifyCourse
    {
        string ErrorMessage { get; }
        bool AddCourse(ICourse person);
        bool DeleteCourse(ICourse person);
        bool EditCourse(ICourse person);
    }
}
