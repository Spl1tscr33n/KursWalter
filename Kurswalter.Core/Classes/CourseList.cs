using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurswalter.Core.Interfaces;

namespace Kurswalter.Core.Classes
{
    public class CourseList
    {
        private List<ICourse> _courseList = new List<ICourse>();

        public List<ICourse> courseList { get; set; }

        public void defaultCourseList()
        {

            var defaultcourseList = new List<ICourse>
                                         {
                                             //todo: ein oder zwei Kurse für testzwecke erstellen
                                         };
            _courseList = defaultcourseList;
        }
    }
}
