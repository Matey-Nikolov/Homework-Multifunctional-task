namespace _02._02._2021
{
    using System;
    
    class Program
    {
        static void Main()
        {
            Circle c1 = new Circle(10, 2.4, 5);
            Circle c2 = new Circle(5, 7.8, 20);
            c1.Print();
            c2.Print();

            Console.WriteLine(InIntersect(c1, c2));
            /*
             ЗАДАЧА 1
            Point p1 = new Point();
            p1.x = 5;
            p1.y = 6.2;
            p1.name = "A";
            p1.Print();

            Point p2 = new Point();
            p2.x = 10.2; // 5
            p2.y = 4.3;  // 6.2
            p2.name = "B";
            p2.Print();

            double dist = Distance(p1, p2);
            Console.WriteLine($"A <-> B: {dist}");
            */
        }

        static double Distance(Point p1, Point p2)
        {
            double d = Math.Sqrt((p1.x - p2.x) * (p1.x - p2.x) + (p1.y - p2.y) * (p1.y - p2.y));
            return d;
        }

        static bool IsInCircle(Circle c, Point p)
        {
            double d = Distance(p, c.center);
            if (d <= c.radius)
            {
                return true;
            }
            return false;
        }

        static bool InIntersect(Circle c1, Circle c2)
        {
            double d = Distance(c1.center, c2.center);
            if(d < c1.radius + c2.radius)
            {
                return true;
            }
            return false;
        }
    }
}