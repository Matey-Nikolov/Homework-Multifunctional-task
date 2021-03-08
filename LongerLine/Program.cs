namespace LongerLine
{
    using System;

    class Program
    {
        static void Main()
        {
            double lineX1 = double.Parse(Console.ReadLine());
            double lineY1 = double.Parse(Console.ReadLine());
            double lineX2 = double.Parse(Console.ReadLine());
            double lineY2 = double.Parse(Console.ReadLine());

            double line1X1 = double.Parse(Console.ReadLine());
            double line1Y1 = double.Parse(Console.ReadLine());
            double line1X2 = double.Parse(Console.ReadLine());
            double line1Y2 = double.Parse(Console.ReadLine());

            PrinLongLine(lineX1, lineY1, lineX2, lineY2, line1X1, line1Y1, line1X2, line1Y2);
        }

        static void PrinLongLine(double lineX1, double lineY1, double lineX2, double lineY2, double line1X1, double line1Y1, double line1X2, double line1Y2)
        {
            double firstLine = Math.Sqrt(Math.Pow((lineX1 - lineX2), 2) + Math.Pow((lineY1 - lineY2), 2));
            double secondLine = Math.Sqrt((line1X1 -line1X2)* (line1X1 - line1X2) + (line1Y1 - line1Y2)* (line1Y1 - line1Y2));

            if (firstLine > secondLine)
            {
               // Console.WriteLine($"({lineX1}, {lineY1})({lineX2}, {lineY2})");
                PrintsPoint(lineX1, lineY1, lineX2, lineY2);
            }
            else
            { 
              //  Console.WriteLine($"({line1X1}, {line1Y1})({line1X2}, {line1Y2})");
                PrintsPoint(line1X1, line1Y1, line1X2, line1Y2);
            }
          
        }

        static void PrintsPoint(double x1, double y1, double x2, double y2)
        {

            double c1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double c2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (c1 <= c2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
    
}
