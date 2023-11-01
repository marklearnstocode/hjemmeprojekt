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
        private static double lowQualityValue;

        public static double LowQualityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = 12.5; }
        }
        private static double mediumQualityValue;

        public static double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = 20.0; }
        }
        private static double highQualityValue;

        public static double HighQualityValue
        {
            get { return highQualityValue; }
            set { highQualityValue = 27.5; }
        }

        public Amulet(string itemID, Level quality, string design)
        {
            ItemID = itemID;
            this.quality = quality;
            this.design = design;
        }
        public Amulet(string itemID, Level quality) : this(itemID, quality, null)
        {

        }
        public Amulet(string itemID) : this(itemID, Level.medium, null)
        {

        }
        public override string ToString()
        {
            return "ItemId: " + ItemID + ", Quality: " + quality + ", Design: " + design;
        }
        public override double GetValue()
        {
            switch (quality)
            {
                case Level.low:
                    return lowQualityValue;
                    break;
                case Level.medium:
                    return mediumQualityValue;
                    break;
                case Level.high:
                    return highQualityValue;
                    break;
                default:
                    return 0;
                    break;
            }
        }

    }
}
