using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheinmetall
{
    public abstract class Goods
    {
        private static double Rheinmetall = 5000;
        private static double Raytheon = 2500;
        private static double KDA = 3500;
        private Quality condition;
        private string nameOfGoods;
        private double price;
        private double manufactor;

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

        public double Manufactor
        {
            get { return manufactor; }
            set
            {
                if (manufactor == Rheinmetall)
                {
                    value = Rheinmetall;
                }
                else if (manufactor == Raytheon)
                {
                    value = Raytheon;
                }
                else if (manufactor == KDA)
                {
                    value = KDA;
                }
                manufactor = value;
            }
        }

        public abstract double GetValue();
    }
}
