using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise
    {
		private string itemID;

		public string ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}
		public override string ToString()
		{
			return $"ItemId: {ItemID}";
		}

	}
}
