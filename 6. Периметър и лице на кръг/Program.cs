using System;

namespace _6._Периметър_и_лице_на_кръг
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("{0:F4}",area);
            Console.WriteLine("{0:F4}",perimeter);
        }
    }
}
