using System;

namespace _04._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            int seconds1 = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());

            int sumseconds = seconds + seconds1 + seconds2;
            int min = sumseconds / 60;
            int sec = sumseconds % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }


        }
    }
}
