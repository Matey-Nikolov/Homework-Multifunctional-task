namespace Homework_List_array
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Option - max, min and average number.");
                Console.WriteLine("2. Option - arrys arevage.");
                Console.WriteLine("3. Option - sort numbers.");
                Console.WriteLine("4. Option - max, min before max, min.");
                Console.WriteLine("5. Option - power of two.");
                Console.WriteLine("6. Option - time sorting battle");
                Console.WriteLine("7. Option - EGN");
                Console.WriteLine("8. Exit");

                int option = 0;

                Console.WriteLine();
                Console.Write("Enter ONLY digits of 1 to 8. ");
                int.TryParse(Console.ReadLine(), out option);


                if (1 >= option && option >= 8)
                {
                    continue;
                }
                else
                {
                    option.ToString();
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Option1 print min, max, average");
                        Option1PrintMinMaxAverage();
                        break;

                    case 2:
                        Console.WriteLine("Random average");
                        RandomAverage();
                        break;

                    case 3:
                        Console.WriteLine("Sort numbers");
                        SortNumbers();
                        break;
                    case 4:
                        Console.WriteLine("No use .Sort()");
                        NoUseSort();
                        break;
                    case 5:
                        Console.WriteLine("Power by two");
                        PowerByTwo();
                        break;
                    case 6:
                        Console.WriteLine("Time sorting battle");
                        TimeSortingBattle();
                        break;
                    case 7:
                        Console.WriteLine("EGN is valid");
                        EGNisValid();
                        break;
                    case 8:
                        Console.WriteLine("Good bye guest.");
                        Console.WriteLine("See you soon!");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Try again");
                        break;
                }
                Console.ReadLine();
            }
        }



        static void EGNisValid()
        {
            // Опция 7
            Console.Write("Enter a EGN: ");
            string egn = Console.ReadLine();

            if (egn.Length != 10)
            {
                Console.WriteLine("Invalid EGN. Must be 10 digits");
                Console.WriteLine("Try again");
                egn = Console.ReadLine();
            }

            int sum = 0;
            int weight = 0;

            for (int i = 0; i < egn.Length - 1; i++)
            {
                int digits = int.Parse(egn[i].ToString());

                switch (i)
                {
                    case 0: weight = 2; break;
                    case 1: weight = 4; break;
                    case 2: weight = 8; break;
                    case 3: weight = 5; break;
                    case 4: weight = 10; break;
                    case 5: weight = 9; break;
                    case 6: weight = 7; break;
                    case 7: weight = 3; break;
                    case 8: weight = 6; break;
                }
                sum += digits * weight;
            }

            int controlDigit = sum % 11;
            controlDigit %= 10;

            if (controlDigit > 10)
            {
                controlDigit = 0;
            }

            if (controlDigit == int.Parse(egn[9].ToString()))
            {
                Console.WriteLine("EGN is valid!");
                Console.WriteLine("Press any key to continue the program.");
            }
            else
            {
                Console.WriteLine("EGN is not valid!");
                Console.WriteLine("Press any key to continue the program.");
            }
        }



        static void TimeSortingBattle()
        {
            // Опция 6
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

            Console.WriteLine("Press any key to continue the program.");
            stopWatch.Reset();
        }


        static void BubbleSort(int[] array)
        {
            // Метод за опция 6.
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
            // Метод за опция 6.
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
            // Метод за опция 6.
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



        static void PowerByTwo()
        {
            //опция 5
            Console.Write("Create a list, separate them with a comma(1, 2, ...): ");

            List<uint> numbers = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(uint.Parse)
                .ToList();

            List<uint> powerof2 = new List<uint>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (IsPower(numbers[i]))
                {
                    if (!powerof2.Contains(numbers[i]))
                        powerof2.Add(numbers[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"All numbers that are power of two: {string.Join(", ", powerof2)}.");
            Console.WriteLine("Press any key to continue the program.");
        }

        static bool IsPower(uint x)
        {
            // метод за опция 5.
            return (x != 0) && ((x & (x - 1)) == 0);
        }



        static void NoUseSort()
        {
            // Опция 4
            Console.Write("Create a list, separate them with a comma(1, 2, ...): ");

            List<int> numbers = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }

            int maxBeforeMax = min;
            int minAfterMin = max;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (min < numbers[i] && numbers[i] < minAfterMin)
                    minAfterMin = numbers[i];
                if (numbers[i] < max && numbers[i] > maxBeforeMax)
                    maxBeforeMax = numbers[i];
            }

            Console.WriteLine();
            Console.WriteLine($"Min number after min: {minAfterMin}.");
            Console.WriteLine($"Max number before max: {maxBeforeMax}.");
            Console.WriteLine("Press any key to continue the program.");
        }



        static void SortNumbers()
        {
            // Опция 3
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter numberN to while enter (-1): ");
                int n = int.Parse(Console.ReadLine());

                if (n == -1)
                {
                    numbers.Sort();
                    Console.WriteLine();
                    Console.WriteLine("The numbers are sorted.");
                    Console.WriteLine(string.Join(", ", numbers));
                    Console.WriteLine("Press any key to continue the program.");
                    break;
                }
                numbers.Add(n);
            }
        }



        static void RandomAverage()
        {
            // Опция 2
            Console.Write("Enter a number N: ");

            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a number M: ");

            int m = int.Parse(Console.ReadLine());

            if (n > m)
            {
                int temp = n;
                n = m;
                m = temp;
            }

            Random rand = new Random();

            int[,] num = new int[10, 100];

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 100; j++)
                {
                    num[i, j] = rand.Next(n, m);
                }

            int arevage = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    arevage = arevage + num[i, j];
                }

                Console.WriteLine($"Array {i}, arevage: {arevage / 100}.");
                arevage = 0;
            }
            Console.WriteLine("Press any key to continue the program.");
        }



        static void Option1PrintMinMaxAverage()
        {
            // Оnция 1 
            Console.Write("Enter a number: ");

            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter new numbers in new line: ");
                int input = int.Parse(Console.ReadLine());
                numbers[i] = input;

                for (int a = 0; a < numbers.Length; a++)
                {
                    if (numbers[i] < min)
                        min = numbers[i];
                    if (numbers[i] > max)
                        max = numbers[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Max number: {max}.");
            Console.WriteLine($"Min number: {min}.");
            Console.WriteLine($"Average of numbers: {numbers.Average()}.");
            Console.WriteLine("Press any key to continue the program.");
        }
    }
}