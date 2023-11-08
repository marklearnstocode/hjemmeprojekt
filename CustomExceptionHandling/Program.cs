using TotallySafeLib;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //try
            //{
                int? posValue = TotallySafe.GetValueAtPosition(-4);

                Console.WriteLine(posValue);

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //catch (NegativeIndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //    double posValue = TotallySafe.Divider(0);
            //    Console.WriteLine(posValue);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    int StringToConvert = TotallySafe.StringToInt("Hej mor");

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();
        }
    }
}