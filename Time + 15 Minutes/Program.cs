using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min = hour * 60 + min + 15;
            hour = min / 60;
            min = min % 60;

            if (hour == 24)
            {
                hour = 0;
            }

            if (min < 10)
            {
                Console.WriteLine($"{hour}:0{min}");
            }
            else
            {
                Console.WriteLine($"{hour}:{min}");
            }

        }
    }
}
