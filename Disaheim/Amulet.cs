using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
		private string itemID;

		public string ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}
		private string design;

		public string Design
		{
			get { return design; }
			set { design = value; }
		}
		private Level quality;

		public Level Quality
		{
			get { return quality; }
			set { quality = value; }
		}
		public Amulet (string itemID, Level quality, string design)
		{
			this.itemID = itemID;
			this.quality = quality;
			this.design = design;
		}
		public Amulet(string itemID, Level quality): this(itemID, quality, null) 
		{

		}
		public Amulet(string itemID): this(itemID, Level.medium, null)
		{

		}
        public override string ToString()
        {
			return "ItemId: " + itemID + ", Quality: " + quality + ", Design: " + design;
        }

    }
}
