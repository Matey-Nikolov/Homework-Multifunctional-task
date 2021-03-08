namespace consylta4._11._2020
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

            CalculateClosetPoint(x1, y1, x2, y2);
        }

        static void CalculateClosetPoint(double x1, double y1, double x2, double y2)
        {
            double closetX = 0;
            double closetY = 0;

            double z1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double z2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (z1 > z2)
            {
                closetX = x2;
                closetY = y2;
            }
            else if (z1 > z2) 
            {
                closetX = x1;
                closetY = y1;
            }
            Console.WriteLine($"({closetX}, {closetY})");

        }
    }
}
