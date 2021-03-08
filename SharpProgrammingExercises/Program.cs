
namespace SharpProgrammingExercises
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            /*
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            
            for (int i = 0; i < num.Length; i++)
            {
                for (int a = i + 1; a < num.Length; a++)
                {
                    if (num[i] < num[a])
                    {
                        int tmp = 0;
                        tmp = num[i];
                        num[i] = num[a];
                        num[a] = tmp;
                        Console.WriteLine(string.Join(" ", num));
                    }
                }
            }
            */
            /*
            int[] sumEven = new int[num.Length];
            int[] sumOdd = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sumEven[i] = num[i];
                }
                else
                {
                    sumOdd[i] = num[i];
                }
            }
            Console.WriteLine(string.Join(" ", sumEven));
            Console.WriteLine(string.Join(" ", sumOdd));
            */

            string[] insert = Console.ReadLine().Split().ToArray();
            if (insert[] == "insert")
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (i == num.Length)
                    {
                        num[i + 1] = insert
                    }
                }
            }

        }
    }
}

