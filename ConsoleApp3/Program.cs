using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCompetitorTime = int.Parse(Console.ReadLine());
            int secondCompetitorTime = int.Parse(Console.ReadLine());
            int thirdCompetitorTime = int.Parse(Console.ReadLine());

            int seconds = firstCompetitorTime + secondCompetitorTime + thirdCompetitorTime;
            int min = 0;

            if (seconds > 59)
            {
                min++;
                seconds = seconds - 60;
            }
            if (seconds > 59)
            {
                min++;
                seconds = seconds - 60;
            }

            if (seconds < 10)
            {
                Console.WriteLine(min + ":" + "0" + seconds);
            }
            else
            {
                Console.WriteLine(min + ":" + seconds);
            }

        }
    }
}
