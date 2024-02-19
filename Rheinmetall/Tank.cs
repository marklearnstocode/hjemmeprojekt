using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheinmetall
{
    public class Tank: Goods
    {
		//private Quality condition;

		//public Quality Condition
		//{
		//	get { return condition; }
		//	set { condition = value; }
		//}
		private int productionYear;

		public int Productionyear
		{
			get { return productionYear; }
			set { productionYear = value; }
		}
		
		public Tank(double manufactor, string nameOfGoods, Quality condition, int productionYear)
		{
			base.Manufactor = manufactor;
			base.NameOfGoods = nameOfGoods;
			base.Condition = condition;
			this.productionYear = productionYear;
		}
		public Tank(Quality condition, int productionYear): this(0, null, condition, productionYear)
		{

		}


		public override double GetValue()
		{
			switch (Condition)
			{
				case Quality.low:
					return (double)Quality.low;
					break;
				case Quality.medium:
					return (double)Quality.medium;
					break;
				case Quality.high:
					return (double)Quality.high;
					break;
				default:
					return 0;
			}
		}
		public string ToString()
		{
			return GetValue() + " Euro";
		}



	}
}
