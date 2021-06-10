namespace BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Queue<int> numbers = new Queue<int>();


            int[] nSX = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

            int number = nSX[0];
            int dequeueRemove = nSX[1];
            int numberLook = nSX[2];

            int[] numNew = new int[number];

            numNew = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < number; i++)
                numbers.Enqueue(numNew[i]);

            for (int a = 0; a < dequeueRemove; a++)
                numbers.Dequeue();

            if (numbers.Count == 0)
                Console.WriteLine("0");
            else if (numbers.Contains(numberLook))
                Console.WriteLine("true");
            else
            {
                int min = numbers.Min();
                Console.WriteLine(min);
            }
        }
    }
}