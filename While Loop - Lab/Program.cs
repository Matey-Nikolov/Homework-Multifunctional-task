using System;

namespace While_Loop___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num < 1 || num > 100)
            {
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}
