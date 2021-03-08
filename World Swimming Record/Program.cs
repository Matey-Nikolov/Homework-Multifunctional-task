using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double second = double.Parse(Console.ReadLine());
            double meter = double.Parse(Console.ReadLine());
            double secondsdistanceof1mswims = double.Parse(Console.ReadLine());

            double Ivancho = meter * secondsdistanceof1mswims;
            double Ivancho15m = Math.Floor((meter/15)) * 12.5;
            double Totaltime = Ivancho + Ivancho15m;

          //  Console.WriteLine($"Ivancho {Ivancho:f2} ");
          //  Console.WriteLine($"Ivancho15m {Ivancho15m:f2} ");
          //  Console.WriteLine($"Totaltime {Totaltime:f2} ");

            if (second <= Totaltime)
            {
                double record = Totaltime - second;
                Console.WriteLine($"No, he failed! He was {record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Totaltime:f2} seconds.");
            }

        }
    }
}
