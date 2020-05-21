using Microsoft.Extensions.Configuration;
using System;

namespace MultimediaConverter.Docker
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration myConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            Console.WriteLine($" Hello { myConfig["name"] } !");
        }
    }
}
