namespace Gennemgang_af_tidligere_opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Navn: ");
            Console.Write("Markus Danielsen");
            Console.Write('\n'+"Alder: ");
            Console.Write("29 år");
            */
            /* Console.WriteLine("Indtast navn: ");
             Console.WriteLine("Navn " + Console.ReadLine());
             Console.WriteLine("Indtast alder: ");
             Console.WriteLine("Alder " + Console.ReadLine());
            */
            /*Console.WriteLine("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast din alder: ");
            int alder = int.Parse(Console.ReadLine());

            Console.WriteLine("Dit navn er {0} og din alder er {1}", navn, alder - 10);
            */
            Console.WriteLine("Indtast navn: ");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast din alder: ");
            string Message = "";
            int alder = int.Parse(Console.ReadLine());

            while (alder < 0 || alder > 100)
            {
                Console.WriteLine("Indtast en gyldig alder");
                alder = int.Parse(Console.ReadLine());
            }

            if (alder >= 0 && alder <= 12) { Message = ("et barn"); }
            else if (alder >= 13 && alder <= 19) { Message = ("en teenager"); }
            else if (alder >= 20 && alder <= 25) { Message = ("en studerende"); }
            else if (alder >= 26 && alder <= 67) { Message = ("i arbejde"); }
            else if (alder > 67 && alder <= 100) { Message = ("en pensionist"); }
            Console.WriteLine(navn + " er " + alder + " år gammel og " + Message);


            Console.ReadKey();



        }
    }
}