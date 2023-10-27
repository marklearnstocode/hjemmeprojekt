using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemID)
        {
            Amulet amulet = null;
            foreach (Amulet a in amulets)
            {
                if (a.ItemID == itemID)
                {
                    amulet = a;
                    break;
                }

            }
            return amulet;
        }
        public double GetTotalValue()
        {
            double total = 0;
            foreach (Amulet a in amulets)
            {
                switch (a.Quality)
                {
                    case Level.low:
                        total += 12.5;
                        break;
                    case Level.medium:
                       total += 20.0;
                        break;
                    case Level.high:
                        total += 27.5;
                        break;
                    default:
                        total += 0;
                        break;
                }
        }
            return total;
    }
    }
}
