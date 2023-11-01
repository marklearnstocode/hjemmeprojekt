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
        public IValuable GetValuable(string iD)
        {
            IValuable valuable = null;
            foreach (IValuable valuable1 in _valuables)
            {
                switch (valuable1)
                {
                    case (Book):
                        if (iD == ((Book)valuable1).ItemID)
                            return valuable1;
                        break;
                    case (Amulet):
                        if (iD == ((Amulet)valuable1).ItemID)
                            return valuable1;
                        break;
                    case (Course):
                        if (iD== ((Course)valuable1).Name)
                            return valuable1;
                        break;
                }
            }
            return valuable;
        }
        public double GetTotalValue()
        {

        }
        public int Count()
        {

        }
    }
}
