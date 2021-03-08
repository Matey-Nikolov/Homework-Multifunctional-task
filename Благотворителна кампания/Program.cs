using System;

namespace Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sweets = int.Parse(Console.ReadLine());
            int cake = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int thepancakes = int.Parse(Console.ReadLine());

            double sumacake = cake * 45.0;
            double sumwaffles = waffles * 5.80;
            double sumthepancakes = thepancakes * 3.20;
            double totalsum = (sumacake + sumwaffles + sumthepancakes) * sweets;

            totalsum *= days;
            totalsum = totalsum - ( 1/8.0 * totalsum);

            Console.WriteLine($"{totalsum:f2}");


        }
    }
}
