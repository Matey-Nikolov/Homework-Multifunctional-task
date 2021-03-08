using System;

namespace program_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double kv = double.Parse(Console.ReadLine());

            double suma = kv * 7.61;
            double a = suma * 0.18;
            double krainasuma = suma - a;


            Console.WriteLine($"The Final price is: {krainasuma:f2} lv.");
            Console.WriteLine($"the discount is: {a:f2} lv.");
        }
    }
}
