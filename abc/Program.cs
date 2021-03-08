using System;

namespace abc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            


            if (a > b)
            {
                int lemp = b;
                b = a;
                a = lemp;
            }


            if (n > a && n < b)
            {
                Console.WriteLine("Inside");
            }
            else if (n < a )
            {
                Console.WriteLine("Far left");
            }
            else if (n == a)
            {
                Console.WriteLine("left");
            }
            else if (n > b)
            {
                Console.WriteLine("Far right");
            }
            else // if (n == b)
            {
                Console.WriteLine("Right");
            }
        }
    }
}
