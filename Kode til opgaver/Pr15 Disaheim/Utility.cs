using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim
{
    public class Utility
    {
        public Double LowQualityValue { get; set; } = 12.5;
        public Double MediumQualityValue { get; set; } = 20.0;
        public Double HighQualityValue { get; set; } = 27.5;
        public Double CourseHourValue { get; set; } = 875.0;

        //public Double GetValueOfBook(Book book)
        //{
        //    Double result = book.Price;
        //    return result;
        //}

        //public Double GetValueOfAmulet(Amulet amulet)
        //{
        //    Double result;
        //    switch (amulet.Quality)
        //    {
        //        case Level.low:
        //            result = 12.5;
        //            break;
        //        case Level.medium:
        //            result = 20;
        //            break;
        //        case Level.high:
        //            result = 27.5;
        //            break;
        //        default:
        //            result = 0;
        //            throw new Exception("Amulet does not have a quality.");
        //    }
        //    return result;
        //}
        public Double GetValueOfMerchandise(Merchandise merchandise)
        {
            Double result = 0;
            if (merchandise is Amulet)
            {
                switch (((Amulet)merchandise).Quality)
                {
                    case Level.low:
                        result = LowQualityValue;
                        break;
                    case Level.medium:
                        result = MediumQualityValue;
                        break;
                    case Level.high:
                        result = HighQualityValue;
                        break;
                    default:
                        throw new Exception("Amulet does not have a quality.");
                }
            }
            else if (merchandise is Book)
            {
                result = ((Book)merchandise).Price;
            }
            return result;
        }
        public Double GetValueOfCourse(Course course)   // 875 per started hour.
        {
            Double result = 0;
            int remainder = course.DurationInMinutes % 60;

            if (remainder > 0)
            {
                result = (course.DurationInMinutes / 60 + 1) * CourseHourValue;
            }
            else if (remainder == 0)
            {
                result = course.DurationInMinutes / 60 * CourseHourValue;
            }

            return result;
        }
    }
}
