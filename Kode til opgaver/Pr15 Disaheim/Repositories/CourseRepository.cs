//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Pr15_Disaheim
//{
//    public class CourseRepository
//    {
//        private List<Course> courses = new List<Course>();

//        public void AddCourse(Course course)
//        {
//            courses.Add(course);
//        }
//        public Course? GetCourse(string name)
//        {
//            Course? course = null;
//            if (courses.Count > 0)
//            {
//                foreach (Course b in courses)
//                {
//                    if (b.Name == name)
//                    {
//                        course = b; break;
//                    }
//                }
//            }
//            return course;
//        }
//        public Double GetTotalValue()
//        {
//            Utility utility = new Utility();
//            Double totalValue = 0;
//            foreach (Course b in courses)
//            {
//                totalValue += utility.GetValueOfCourse(b);
//            }
//            return totalValue;
//        }
//    }
//}
