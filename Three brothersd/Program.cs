using System;

namespace Three_brothersd
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double dad = double.Parse(Console.ReadLine());

            double time = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            double breakTime = (time * 0.15) + time;
            double timeLeft = dad - breakTime;

            Console.WriteLine($"Cleaning time: {breakTime:f2}");
            if (timeLeft > 0)
            {
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(timeLeft)} hours.");
            }
            else
            {
                timeLeft = Math.Abs(timeLeft);
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeLeft)} hours.");
            }
        }
    }
}
