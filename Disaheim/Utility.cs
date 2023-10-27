using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                    break;
                case Level.medium:
                    return 20.0;
                    break;
                case Level.high:
                    return 27.5;
                    break;
                default:
                    return 0;
                    break;
            }
        }
        public double GetValueOfCourse(Course course)
        {
            int valueOfCourse = course.DurationInMinutes /60;
            int rest = course.DurationInMinutes %60;
            if (rest > 0)
            {
                valueOfCourse++;
            }
            //return valueOfCourse <0 ? (rest +1) * 875 : rest * 875;
            return valueOfCourse * 875;
        }
    }
}
