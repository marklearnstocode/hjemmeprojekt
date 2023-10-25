namespace constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        class Jbro
        {
            string navn;
            string evner;
            int age;
            double højde;

            public Jbro (string navn, string evner, int age, double højde)
            {
                this.navn = navn;
                this.evner = evner;
                this.age = age;
                this.højde = højde;
            }
            public void Beskrivelse()
            {
                Console.WriteLine("Hans er navn er " + navn + ", han har evnen til " + evner + " " + ", han er " + age + " år gammel og " + "og han er " + højde + " cm høj");
            }
        }
    }
}