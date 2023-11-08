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
        public static int? GetValueAtPosition(int positionInArray)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            int? heyfriends = null;
            try
            {
                int heyFriends = intArray[positionInArray];
            }
            catch (IndexOutOfRangeException e)
            {
                if (positionInArray < 0)
                {
                    Console.WriteLine("din mor");
                    throw new NegativeIndexOutOfRangeException();

                }
                else
                    throw new IndexOutOfRangeException("Du må ikke indtaste højere end 4");
            }
            return heyfriends;
        }
    }
}

