using System;

namespace NestedLoops_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                for (int ia = a; ia <= b; ia++)
                {
                    for (int ic = c; ic <= d; ic++)
                    {
                        for (int ac = c; ac <= d; ac++)
                        {
                            if (((i + ic) == (ia + ac) && (i != ia) && (ic != ac)))
                            {
                                Console.WriteLine($"{i}{ia}");
                                Console.WriteLine($"{ac}{ic}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }

        }
    }
}
