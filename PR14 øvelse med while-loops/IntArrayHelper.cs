using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR14_øvelse_med_while_loops
{
    public class IntArrayHelper
    {
        public void SortAscending(int[] intArray)
        {
            int temp = 0;
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }

            foreach (int number in intArray)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
        public void SortAscendingAndReverse(int[] intArray)
        {
            
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in descending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
