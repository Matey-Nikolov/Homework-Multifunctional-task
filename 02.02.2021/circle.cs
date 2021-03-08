using System;
using System.Collections.Generic;
using System.Text;

namespace _02._02._2021
{
    class Circle
    {
        public Point center;
        public double radius;

        public Circle(double x, double y, double radius)
        {
            this.radius = radius;
            this.center = new Point(x, y);
        }


        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public void Print()
        {
            Console.WriteLine($"Circle: (({center.x}, {center.y}), {radius})");
        }
    }
}
