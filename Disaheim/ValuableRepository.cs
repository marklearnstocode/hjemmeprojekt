using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> _valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {

        }
        public IValuable? GetValuable(string iD)
        {
            IValuable valuable = null;
            foreach (IValuable valuable1 in _valuables)
            {
                if (valuable1 is Book)
                {
                    if (iD == ((Book)valuable1).ItemID)
                    {
                    return valuable1;
                    }
                }
                else if (valuable1 is Amulet)
                {
                    if (iD == ((Amulet)valuable1).ItemID)
                    {
                        return valuable1;
                    }
                }
                else if (valuable1 is Course)
                {
                    if (iD == ((Amulet)valuable1).ItemID)
                    {
                        return valuable1;
                    }
                }

            }
            return valuable;

        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (IValuable valuable1 in _valuables)
            {
                if (valuable1 is Book)
                {
                    totalValue += ((Book)valuable1).GetValue();
                }
                else if (valuable1 is Amulet)
                {
                    totalValue += ((Amulet)valuable1).GetValue();
                }
                else if (valuable1 is Course)
                {
                    totalValue += ((Course)valuable1).GetValue();

                }
            }
            return totalValue;
        }
        public int Count()
        {
            return _valuables.Count;
        }
    }
}
