namespace CenterPoint
{
    using System;

    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintsPoint(x1, y1, x2, y2);
        }

        static void PrintsPoint(double x1, double y1, double x2, double y2)
        {

            double c1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double c2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (c1 <= c2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}