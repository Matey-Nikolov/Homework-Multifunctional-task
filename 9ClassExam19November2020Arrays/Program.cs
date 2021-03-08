namespace _9ClassExam19November2020Arrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] values = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();
            int max = 0;
            int eg = 0;

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = values.Length - 1; j >= i; j--)
                {
                    if (values[i] == values[j])
                    {
                        eg++;
                    }
                    else
                    {
                        eg = 0;
                    }
                    if (values[i] >= values[j])
                        max = values[i];
                    else
                        break;
                }

                if (max != 0)
                {
                    Console.Write(max + " ");
                    max = 0;
                }


            }
            if (eg > 0)
            {
                Console.Write($"There are {eg} identical numbers");
            }

        }
    }
}
