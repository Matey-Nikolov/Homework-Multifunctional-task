using System;

namespace TriangleofDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            { 
               // Console.Write("$");
                for (int a = 1; a <= i; a++)
                {
                    Console.Write(new string("$"));
                }
                Console.WriteLine();
            }

        }
    }
}