using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
		
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
			ItemID = itemID;
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
			return "ItemId: " + ItemID + ", Quality: " + quality + ", Design: " + design;
        }

    }
}
