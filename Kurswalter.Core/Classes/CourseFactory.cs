using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursWalter.Core.Interfaces;
using KursWalter.Core.Structs;

namespace KursWalter.Core.Classes
{
    public class CourseFactory
    {
        private readonly ICourse _course;
        private readonly DateTime _creationdate;
        private readonly string _shortContent;
        private readonly string _longContent;


        //private List<IPerson> _member;
        //private List<IDateAndPlace> _happenings;

        public CourseFactory(ICourse course, string shortContent, string longContent)
        {
            _course = course;;
            _shortContent = shortContent;
            _longContent = longContent;
            _creationdate = DateTime.Now;
        }


        //Todo: (Rico) vllt hier nochmals aussplitten in CourseFactory und darüber eine CourseListFactory bauen?
        public void createCourse()
        {
            _course.addHappening(new DateAndPlace(new DateTime(2014, 7, 8, 10, 30, 00), "Moon"));   //verstoß gegen dry ist mir bewusst... aber viel gerade noch nix besseres ein sry... am schluff vllt mit ner whil schleife die so lange läuft bis user knopf drückt damit es weiter geht
            _course.addHappening(new DateAndPlace(new DateTime(2014, 7, 9, 11, 30, 00), "Sun"));
            _course.addHappening(new DateAndPlace(new DateTime(2014, 7, 10, 20, 30, 00), "Earth"));
            _course.addHappening(new DateAndPlace(new DateTime(2014, 7, 11, 14, 30, 00), "Pluto"));

            _course.AddMember(new Person("hello", "wold", "ape", "NaN", "", "", null, new DateTime(1936, 7, 11)));
            _course.AddMember(new Person("by", "by", "American", "Pi", "Mrs.", "", null, new DateTime(1974, 8, 5)));

            _course.LongContent = _longContent;
            _course.ShortContent = _shortContent;
        }

        public ICourse NewCourse
        {
            get { return _course; }
        }
    }
}
