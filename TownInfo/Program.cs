
namespace TownInfo
{
    using System;

    class Program
    {
        static void Main()
        {
            string nameTown = Console.ReadLine();
            int population =int.Parse( Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine(ReturnTownInfo(nameTown, population, area));
        }

        static string ReturnTownInfo(string nameTown, long population, long area)
        {
            string townInfo = "";
            return townInfo = $"Town {nameTown} has population of {population} and area {area} square km.";
        }
    }
}
