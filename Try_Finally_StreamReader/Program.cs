using System.IO.Enumeration;

namespace Try_Finally_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            filestream
                string fileName = "Test.txt";
                StreamWriter SW = new StreamWriter(fileName);
            try
            {
                SW.WriteLine("Kenobi: Hello There");
           
            }
            finally
            {
                SW.Close();

            }
                StreamReader SR = new StreamReader(fileName);
            try
            {
                Console.WriteLine(SR.ReadToEnd());
            }
            finally
            {
            SR.Close();

            }
        }
    }
}