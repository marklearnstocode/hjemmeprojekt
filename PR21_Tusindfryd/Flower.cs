using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR21_Tusindfryd
{
    public class Flower
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int productionTimeInDays;

		public int ProductionTimeInDays
		{
			get { return productionTimeInDays; }
			set { productionTimeInDays = value; }
		}
		private double halfChangeOfValue;

		public double HalfChangeOfValue
		{
			get { return halfChangeOfValue; }
			set { halfChangeOfValue = value; }
		}
		private double size;

		public double Size
		{
			get { return size; }
			set { size = value; }
		}
		public Flower(string Name, int ProductionTimeInDays, double HalfChangeOfValue, double Size)
		{
			name = Name;
			productionTimeInDays= ProductionTimeInDays;
			halfChangeOfValue= HalfChangeOfValue;
			size = Size;
		}
	}
}
