using System;
using KursWalter.Core.Interfaces;

namespace KursWalter.WpfClient.ViewModels
{
    public class CourseViewModel : ICourseViewModel
    {
        private readonly ICourse _course;

        public CourseViewModel(ICourse course)
        {
            if (course == null) throw new ArgumentNullException("course");
            _course = course;
        }

        public ICourse Course
        {
            get { return _course; }
        }
    }
}
