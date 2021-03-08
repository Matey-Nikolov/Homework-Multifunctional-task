using System;
using System.Collections.Generic;
using System.Text;

namespace _02._02._2021
{
    public class Point
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double x;
        public double y;
        public string name;

        public void Print()
        {
            Console.WriteLine($"{name}({x}, {y})");
        }
    }
}
