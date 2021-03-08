
namespace Тепаведанни2
{
    using System;

    class Program
    {
        static void Main()
        {
            double a = 0;

            for (int i = 0; i < 10; i++)
            {
                a += 0.1;
            }

            double b = 1.0; // 1.0 - 0.999999.. = 0.00001

            if (Math.Abs(a - b) < 0.001) // (b - a), (a - b)
                Console.WriteLine("Equals");
            else
                Console.WriteLine("Not equals");


            bool l = true;
            if (l)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            double num = 0.0 / 0.0; // 0.0 / 0.0; - NaN.
            Console.WriteLine(num); // изписва се знака за безкрайност

        }
    }
}
