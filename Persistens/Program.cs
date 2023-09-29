namespace Persistens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_CUST = 3;
            Person[] persons = new Person[MAX_CUST];
            persons[0] = new Person("Ulla Pedersen", new DateTime(1994, 3, 29), 186.5, false, 1);
            persons[1] = new Person("Sully Pedersen", new DateTime(1995, 4, 30), 187.5, false, 2);
            persons[2] = new Person("Henrik Plovmand", new DateTime(1965, 12, 25), 177.2, true, 4);
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 23), 175.9, true, 3);

            DataHandler handler = new DataHandler("Data.txt");
            //handler.SavePerson(person);
            handler.SavePersons(persons);

            Console.Write("Writing Person: ");
            Console.WriteLine(person.MakeTitle());
            Console.WriteLine(persons[0].MakeTitle());
            Console.ReadKey();


        }
    }
}