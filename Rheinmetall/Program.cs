namespace Rheinmetall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank Tiger = new Tank(Quality.medium, 1990);
            Console.WriteLine(Tiger.ToString());
        }
    }
}
