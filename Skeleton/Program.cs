using System;

namespace Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            double Gotothecontrol = double.Parse(Console.ReadLine());
            double Secondsofcontrol = double.Parse(Console.ReadLine());
            double Thelengtchute = double.Parse(Console.ReadLine());
            double Seconds100meters = double.Parse(Console.ReadLine());

            double Timesecondscontrol = (Gotothecontrol * 60.0) + Secondsofcontrol;
            double Timewilldecrease = Thelengtchute / 120.0;
            double Totaldecrease = Timewilldecrease * 2.5;

            double Marintime = (Thelengtchute / 100.0) * Seconds100meters - Totaldecrease;

            if (Marintime <= Timesecondscontrol)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {Marintime:f3}.");
            }
            else
            {
                double Notenough = Timesecondscontrol - Marintime;
                Console.WriteLine($"No, Marin failed! He was {Math.Abs(Notenough):f3} second slower.");
            }
        }
    }
}
