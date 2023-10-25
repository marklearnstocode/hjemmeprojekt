using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
		private string itemID;

		public string ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}
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
			this.itemID = itemID;
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
            return "ItemId: " + itemID + ", Title: " + title + ", Price: " + price;
        }

    }
}
