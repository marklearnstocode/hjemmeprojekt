using System.Xml.Serialization;

namespace Gennemgang_af_tidligere_opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PR_01FirstProgram
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
            #endregion
            #region PR_02Conditionals
            //Console.WriteLine("Indtast navn: ");
            //string navn = Console.ReadLine();
            //Console.WriteLine("Indtast din alder: ");
            //string Message = "";
            //int alder = int.Parse(Console.ReadLine());

            //while (alder < 0 || alder > 100)
            //{
            //    Console.WriteLine("Indtast en gyldig alder");
            //}

            //if (alder >= 0 && alder <= 12) { Message = ("er et barn"); }
            //else if (alder >= 13 && alder <= 19) { Message = ("er en teenager"); }
            //else if (alder >= 20 && alder <= 25) { Message = ("er en studerende"); }
            //else if (alder >= 26 && alder <= 67) { Message = ("er i arbejde"); }
            //else if (alder > 67 && alder <= 100) { Message = ("er en pensionist"); }
            //Console.WriteLine(navn + " er " + alder + " år gammel og " + Message);


            //Console.ReadKey();
            //Console.WriteLine("Min fantastiske menu:");
            //Console.WriteLine("");
            //Console.WriteLine("1. Gør dit");
            //Console.WriteLine("2. Gør dat");
            //Console.WriteLine("3. Gør noget helt andet");
            //Console.WriteLine("4. Bliv datamatiker");
            //Console.WriteLine("");
            //Console.WriteLine("Tryk menupunkt 1,2, 3 eller 4 for at vælge");
            //string message = "";
            //string choice = "";
            //int Menupunkt = int.Parse(Console.ReadLine());
            //#region switch case løsning
            ////switch (Menupunkt)
            ////{
            ////    case 1:
            ////        Console.WriteLine("Punkt 1 er valgt: Gør dit");
            ////        break;
            ////    case 2:
            ////        Console.WriteLine("Punkt 2 er valgt: Gør dat");
            ////        break;
            ////    case 3:
            ////        Console.WriteLine("Punkt 3 er valgt: Gør noget helt andet");
            ////        break;
            ////    case 4:
            ////        Console.WriteLine("Punkt 4 er valgt: Du blev datamatiker!");
            ////        break;
            ////        default: Console.WriteLine("Du skal indtaste enten 1,2 3 eller 4");
            ////        break;
            //// }
            //#endregion
            //while (Menupunkt < 1 || Menupunkt > 4)
            //{
            //    Console.WriteLine("Indtast en gyldig valgmulighed");
            //    Menupunkt = int.Parse(Console.ReadLine());

            //}
            //if (Menupunkt > 0 && Menupunkt < 2) { choice = "1"; message = ("Gør dit"); }
            //else if (Menupunkt > 1 && Menupunkt < 3) { choice = "2"; message = ("Gør dat"); }
            //else if (Menupunkt > 2 && Menupunkt < 4) { choice = "3"; message = ("Gør noget helt andet"); }
            //else if (Menupunkt > 3 && Menupunkt < 5) { choice = "4"; message = ("Du blev datamatiker!"); }
            //Console.WriteLine("Punkt {0} er valgt: {1}", choice, message);
            //Console.ReadKey();
            #endregion
            #region PR_03CSharpData
            //Beregnen af areal fra en rektangel
            //Console.WriteLine("Beregn areal for et rektangel");
            //Console.WriteLine("Indtast højden på rektanglet i cm: ");
            //int højde = int.Parse(Console.ReadLine());
            //Console.WriteLine("Indtast bredden på rektanglet i cm: ");
            //int bredde = int.Parse(Console.ReadLine());

            //Console.WriteLine("Rektanglets areal er: " + højde * bredde + " cm.");
            //Console.ReadLine();

            #region Øvelse 3.2: Hældning af linjestykke
            //Console.WriteLine("Hældning af linjestykke-beregner");
            //Console.WriteLine("Skriv startpunktets x_1 koordinat.");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv startpunktets y_1 koordinat.");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv slutpunktets x_2 koordinat.");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Skriv slutpunktets y_2 koordinat.");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Hældningen af linjestykket er: " + (y2 -  y1)/(x2 - x1));
            //Console.ReadKey();
            #endregion
            #region Øvelse 4: manipulation af tekststrenge
            //string testStreng = "Her er en længere tekststreng, som jeg vil bruge til mit eksempel";
            //string længdeAfTekststreng = testStreng.Substring(0, 7);
            //string testStreng1 = "kort";
            //int længde  = testStreng1.IndexOf("r");
            //Console.WriteLine(længdeAfTekststreng);
            //Console.WriteLine(længde);

            #endregion

            #endregion
            #region PR_04Loops
            //string navn = "Markus";
            //char ch = navn[1];
            //char ch2 = navn[3];
            //char ch3 = navn[5];
            //Console.WriteLine(ch + " " + ch2 + " " + ch3);
            //Console.ReadKey();

            string name = "Markus";
            while (name < 5)
            {
                Console.WriteLine(name[0] : {0}, name );
            }

            #endregion
        }
    }
}