using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheinmetall
{
    public abstract class Goods
    {
        private Quality condition;
        private string nameOfGoods;
		private double price;
		private string manufactor;

        public Quality Condition
        {
            get { return condition; }
            set { condition = value; }
        }

		public string NameOfGoods
		{
			get { return nameOfGoods; }
			set { nameOfGoods = value; }
		}

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public string Manufactor
		{
			get { return manufactor; }
			set { manufactor = value; }
		}

		public abstract double GetValue();
	}
}
