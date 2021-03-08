using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();

            if (day < 10)
            {
                switch (room)
                {
                    case "room for one person":
                        break;
                    case "apartment":
                        break;

                }
            }
        }
    }
}
