namespace Disaheim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Amulet pp = new Amulet("Navn", Level.high, "Design");

            Console.WriteLine(pp.ToString());

            Console.ReadKey();
        }
    }
}