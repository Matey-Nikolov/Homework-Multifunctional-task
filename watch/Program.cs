namespace watch
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            List<int> numbers = new List<int> { 100, 200, 150, 120, 110};

            BubbleSort(numbers);
            stopWatch.Stop();
            Console.WriteLine("Bubble Sort: ");
            Console.WriteLine(stopWatch.Elapsed);

            stopWatch.Reset();
            //...

            // случайни числа

            Random rand = new Random();
            for (int ctr = 0; ctr <= 100000; ctr++)
            {
                Console.Write("{0}", rand.Next(-100, 100));
            }

            // Average
            double sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            double average = sum / numbers.Count;
            numbers.Average();
        }

        static bool IsPowerOfTen(int number)
        {
            if (number % 10 == 0)
            {
                return true;
            }
            return false;
        }

        static void BubbleSort(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < list.Count; i++)
            {
                int b;
                for (int j = 0; i < n - i - 1; i++)
                {
                    if (list[i] < list[j + 1])
                    {
                        b = list[i];
                        list[i] = list[i + 1];
                        b = list[i + 1];
                    }
                }
            }
        }
    }
}
