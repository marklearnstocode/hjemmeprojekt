using Microsoft.Extensions.Configuration;

namespace GetTheNukes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            string? ConnectionString = config.GetConnectionString("MyDBConnection");
        }
    }
}
