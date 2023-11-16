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
			set { courseHourValue = value; }
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
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {

            int DurationInHour = DurationInMinutes / 60;
            int rest = DurationInMinutes % 60;
            if (rest > 0)
            {
                DurationInHour++;
            }
			return courseHourValue * DurationInHour;
        }
    }
}
