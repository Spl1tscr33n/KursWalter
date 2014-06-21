using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursWalter.Core.Interfaces
{
    public interface ICourseFactory
    {
        ICourse createCourse(string name, string dozent, string shortContent, string longContent);
    }
}
