using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(string name)
        {
            Course course = null;
            foreach (Course c in courses)
            {
                if (c.Name == name)
                {
                    course = c;
                    break;
                }

            }
            return course;
        }
        public double GetTotalValue()
        {
            {
                double total = 0;
                foreach (Course c in courses)
                {
                    int valueOfCourse = c.DurationInMinutes / 60;
                    int rest = c.DurationInMinutes % 60;
                    if (rest > 0)
                    {
                        valueOfCourse++;
                    }
                    //return valueOfCourse <0 ? (rest +1) * 875 : rest * 875;
                    total += valueOfCourse * 875;
                }
                return total;
            }
        }
    }
}
