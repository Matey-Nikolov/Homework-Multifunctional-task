using System;
using System.Numerics;

namespace Nested_Loops___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin1 = int.Parse(Console.ReadLine());
            int pin2 = int.Parse(Console.ReadLine());
            int pin3 = int.Parse(Console.ReadLine());

            int code1 = 0;
            int code2 = 0;
            int code3 = 0;

            for (int i = 1; i <= pin1; i++)
            {
                if (i % 2 == 0)
                {
                    code1 = i;
                }
                else
                {
                    continue;
                }



                for (int a = 1; a <= pin2; a++)
                {
                    if (a == 2 || a == 3 || a == 5 || a==7)
                    {
                        code2 = a;
                    }
                    else
                    {
                        continue;
                    }


                    for (int b = 1; b <= pin3; b++)
                    {
                        if (b % 2 == 0)
                        {
                            code3 = b;
                        }
                        else
                        {
                            continue;
                        }

                        Console.WriteLine($"{code1}{code2}{code3}");
                    }
                }
                            
            }


        }
    }
}
