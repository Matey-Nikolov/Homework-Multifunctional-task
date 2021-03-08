using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (int b = 97; b < 97 + l; b++) // Ще видя цифрите в ascii таблицата. Ще взема стойността на а.
                    {
                        for (int b2 = 97; b2 < 97 + l; b2++)
                        {
                            int number = Math.Max(i, i2) + 1;

                            for (int c = number; c <= n; c++)
                            { 
                              
                                Console.Write($"{i}{i2}{(char)b}{(char)b2}{c} ");
                                
                            }
                        }
                    }
                }
            }

        }
    }
}
