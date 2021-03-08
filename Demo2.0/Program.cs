using System;

namespace Demo2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string evenodd = Console.ReadLine();

            for (int i = 0; i < 1000; i++)
            {
                // if (i % 10 == 7)
                // {
                //     Console.WriteLine(i);
                // }

                if (i % 2 == 0 && evenodd == "even")
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 != 0 && evenodd == "odd")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Invalid commend");
                }
            }
        }
    }
}


