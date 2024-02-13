using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheinmetall
{
    public class Tank: Goods
    {
		private Quality condition;

		public Quality Condition
		{
			get { return condition; }
			set { condition = value; }
		}
		private int productionYear;

		public int Productionyear
		{
			get { return productionYear; }
			set { productionYear = value; }
		}
		
		public Tank(string manufactor, string nameOfGoods, Quality condition, int productionYear)
		{
			base.Manufactor = manufactor;
			base.NameOfGoods = nameOfGoods;
			this.condition = condition;
			this.productionYear = productionYear;
		}
		public Tank(Quality condition, int productionYear): this(null, null, condition, productionYear)
		{

		}


		public double GetValue()
		{
			switch (condition)
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



	}
}
