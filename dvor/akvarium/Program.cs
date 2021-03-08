using System;

namespace akvarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double aa = double.Parse(Console.ReadLine());

            int sum = h * d * w;
            double sum2 = sum * 0.001;
            double sum3 = aa * 0.01;
            double sum4 = sum2 * (1 - sum3 );

            Console.WriteLine($"resul: {sum4:f3} cm3");
        }
    }
}
