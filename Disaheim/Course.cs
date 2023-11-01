using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int durationInMinutes;

		public int DurationInMinutes
		{
			get { return durationInMinutes; }
			set { durationInMinutes = value; }
		}
		private static double courseHourValue;

		public static double CourseHourValue
		{
			get { return courseHourValue; }
			set { courseHourValue = 875.0; }
		}

		public Course(string name, int durationInMinutes)
		{
			this.name = name;
			this.durationInMinutes = durationInMinutes;
		}
		public Course(string name) : this(name, 0)
		{

		}
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }

        public double GetValue()
        {

            int valueOfCourse = DurationInMinutes / 60;
            int rest = DurationInMinutes % 60;
            if (rest > 0)
            {
                valueOfCourse++;
            }
            return valueOfCourse < 0 ? (rest + 1) * 875 : rest * 875;
        }
    }
}
