using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheinmetall
{
    public class Goods
    {
		private string nameOfGoods;

		public string NameOfGoods
		{
			get { return nameOfGoods; }
			set { nameOfGoods = value; }
		}
		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}
		private string manufactor;

		public string Manufactor
		{
			get { return manufactor; }
			set { manufactor = value; }
		}


	}
}
