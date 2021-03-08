
namespace ex1._6
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Stopwatch stopWatch = new Stopwatch();
            Random rand = new Random();

            int[] numbers = new int[100000]; 
            int[] numbers1 = new int[100000];
            int[] numbers2 = new int[100000];
            int[] numbers3 = new int[100000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-100, 100);
            }

            numbers.CopyTo(numbers1, 0);
            numbers.CopyTo(numbers2, 0);
            numbers.CopyTo(numbers3, 0);

            Console.WriteLine();
            stopWatch.Start();
            GnomeSort(numbers);
            stopWatch.Stop();
            Console.WriteLine("GnomeSort time: ");
            Console.WriteLine(stopWatch.Elapsed);

            stopWatch.Reset();

            Console.WriteLine();
            stopWatch.Start();
            BubbleSort(numbers);
            stopWatch.Stop();
            Console.WriteLine("Bubble Sort time: ");
            Console.WriteLine(stopWatch.Elapsed);

            stopWatch.Reset();

            Console.WriteLine();
            stopWatch.Start();
            Array.Sort(numbers);
            stopWatch.Stop();
            Console.WriteLine("Sort time: ");
            Console.WriteLine(stopWatch.Elapsed);

            stopWatch.Reset();

            Console.WriteLine();
            stopWatch.Start();
            InsertionSort(numbers);
            stopWatch.Stop();
            Console.WriteLine("InsertionSort time: ");
            Console.WriteLine(stopWatch.Elapsed);

            stopWatch.Reset();
        }

        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                int b;
                for (int j = 0; i < n - i - 1; i++)
                {
                    if (array[i] < array[j + 1])
                    {
                        b = array[i];
                        array[i] = array[i + 1];
                        b = array[i + 1];
                    }
                }
            }
        }

        static int[] InsertionSort(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                int number = num[i];
                int index = i;
                while (index > 0 && num[index - 1] >= number)
                {
                    num[index] = num[index - 1];
                    index--;
                }
                num[index] = number;
            }
            return num;
        }

        static void GnomeSort(int[] num)
        {
            for (int i = 1; i < num.Length;)
            {
                if (num[i - 1] <= num[i])
                {
                    ++i;
                }
                else
                {
                    //int tmp = num[i];
                    num[i] = num[i - 1];
                    --i;
                    if (i == 0)
                        i = 1;
                }
            }
        }

    }
}