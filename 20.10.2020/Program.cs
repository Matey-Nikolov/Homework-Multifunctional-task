using System;

namespace _20._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1 + 0.1;
            double b = 8 * 0.1; // 5*0.1

            if (Math.Abs(a - b) < 0.01)
            {
                Console.WriteLine("Yes"); // .05 * 0.1 
            }
            else
            {
                Console.WriteLine("No"); // 0.1 + 0.1 ..... 8 
            }
        }
    }
}
