using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    for (int j = 0; j < n * 2; j++)
                    {
                        Console.Write("*");
                    }
                    for (int l = 0; l < n; l++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < n * 2; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int k = 1; k <= n * 2 - 2; k++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");

                    for (int l = 0; l < n; l++)
                    {

                        if (i == (n - 1) / 2)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }






                    }
                    Console.Write("*");
                    for (int k = 1; k <= n * 2 - 2; k++)
                    {
                        Console.Write("/");
                    }
                    Console.Write("*");


                }



                Console.WriteLine();
            }

        }
    }
}
