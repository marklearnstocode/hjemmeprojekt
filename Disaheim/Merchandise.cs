using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
	public abstract class Merchandise : IValuable
	{
		private string itemID;

		public string ItemID
		{
			get { return itemID; }
			set { itemID = value; }
		}

		public abstract double GetValue();

		public override string ToString()
		{
			return $"ItemId: {ItemID}";
		}
		public string GetId()
		{
			return itemID;
		}

		public abstract string InfoString();

	}
}
