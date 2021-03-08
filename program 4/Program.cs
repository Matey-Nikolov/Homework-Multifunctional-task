using System;

namespace program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dog = int.Parse(Console.ReadLine());
            int ost = int.Parse (Console.ReadLine());

            double a = dog * 2.5;
            double b = ost * 4;
            double c = a + b;
            Console.WriteLine($"{c:f2} lv.");


        }
    }
}
