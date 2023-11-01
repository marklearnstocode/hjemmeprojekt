using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}
		public Book(string itemID, string title, double price)
		{
			ItemID = itemID;
			this.title = title;
			this.price = price;
		}
		public Book(string itemID, string title): this(itemID, title, 0)
		{

		}
		public Book(string itemID): this(itemID, null, 0)
		{

		}
        public override string ToString()
        {
            return "ItemId: " + ItemID + ", Title: " + title + ", Price: " + price;
        }
        public override double GetValue()
        {
            return price;
        }
    }
}
