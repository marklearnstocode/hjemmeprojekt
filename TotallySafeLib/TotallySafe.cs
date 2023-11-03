using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TotallySafeLib
{
    public class TotallySafe
    {
        public static double Divider(int number)
        {
            return 7 / number;
        }
        public static int StringToInt(string stringToConvert)
        {
            return int.Parse(stringToConvert);
        }
        public static int GetValueAtPosition(int positionInArray)
        {
            if (positionInArray < 0)
                throw new NegativeIndexOutOfRangeException();
            else if (positionInArray > 4)
                throw new IndexOutOfRangeException("Du må ikke indtaste højere end 4");
            int[] intArray = { 1, 2, 3, 4, 5 };
            return intArray[positionInArray];
        }
    }
}

