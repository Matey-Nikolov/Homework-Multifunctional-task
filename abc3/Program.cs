using System;

namespace abc3
{
    class Program
    {
        static void Main(string[] args)
        {
            double xc = double.Parse(Console.ReadLine());
            double yc = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            
            double xp = double.Parse(Console.ReadLine());
            double yp = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt((xp - xc)*(xp - xc) + (yp - yc)*(yp - yc));


            if (distance > r)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
