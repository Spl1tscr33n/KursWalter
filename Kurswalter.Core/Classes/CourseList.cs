using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;

namespace KursWalter.Core.Classes
{
    public class CourseList
    {
        private List<ICourse> _courseList = new List<ICourse>();

        public List<ICourse> courseList { get; set; }

        public void defaultCourseList()
        {
            var first = new CourseFactory(new Course("HowToCryUnderShower", "shower head"), "step by step", "crying and bobbing");
            var second = new CourseFactory(new Course("Ufology for advanced", "I.T."), "wantToCallHome", "What to do if you have fisit from out of space");
            
            var defaultcourseList = new List<ICourse>
                                         {
                                             first.NewCourse,
                                             second.NewCourse
                                             //todo: ein oder zwei Kurse für testzwecke erstellen
                                         };
            _courseList = defaultcourseList;
        }

    }
}
