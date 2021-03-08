namespace TEST2021v2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine(Euclid1GCD(Euclid1GCD(12, 18), 36));

            Console.WriteLine(LCM(LCM(10, 100), 1000));
            Console.WriteLine(LCM(2, 3));
            
            Console.WriteLine(CountDidit8(884623468));

            Console.WriteLine(CountWord("uitygukj"));

            Console.WriteLine(CountWordEnd("yttt"));


            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> a = ListDigit(numbers);
            Console.WriteLine(string.Join(" ", a));
            

            ABC(1, 2, 3);

            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Select(arr);
            */

         List<int>   a = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToList();

          List<int>  b = Console.ReadLine()
                                .Split(" ")
                                .Select(int.Parse)
                                .ToList();
            
            Console.WriteLine(Get(a, b));

        }

        static int Euclid1GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }


        // A or B 
        static int LCM(int a, int b)
        {
            for (int i = Math.Max(a, b); i <= a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    return i;
                }
            }
            return a * b;
        }

        // 4
        static void Number4(string a)
        {
            int[] numbers = new int[10];
                int num = int.Parse(a);

            while (num != 0)
            {
                int gigit = num % 10;
                for (int i = 0; i < a.Length; i++)
                {
                    numbers[i] += num;
                    Console.WriteLine($"{numbers[i]}");
                }

                num /= 10;
            }


        }

        // 5
        static int CountDidit8(int num) //CountDidit5
        {
            int cnt = 0;
            while (num != 0)
            {
                int gigit = num % 10;
                if (gigit == 8)//5
                {
                    cnt++;
                }
                num /= 10;
            }
            return cnt;
        }

        // 5 - word
        static int CountWord(string word) 
        {
            int cnt = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 't' || word[i] == 'T')
                {
                    cnt++;
                }
            }
            return cnt;
        }

        // 5 - word
        static int CountWordEnd(string word)
        {
            int cnt = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 't' || word[i] == 'T')
                {
                    cnt++;
                }
                else
                {
                    break;
                }
            }
            return cnt;
        }

        // 7
        static List<int> ListDigit(List<int> numbers)
        {
            List<int> numDigit = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    numDigit.Add(numbers[i]);
                }
            }
            return numDigit;
        }

        // 8 
        static void StringChar()
        {
            string input = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (counts.ContainsKey(input[i]) == false)
                    {
                        counts.Add(input[i], 0);
                    }
                    counts[input[i]]++;
                }
            }
        }

        // 10
        static void ABC(int a, int b, int c)
        {

            //  a = int.Parse(Console.ReadLine());
            // b = int.Parse(Console.ReadLine());
            // c = int.Parse(Console.ReadLine());
            int r = 0;
            int arrayAa = a;
            int arrayA = a + b;
            int arrayB = a + 2 * b;
            int arrayC = a + (3 * b) * a + (4 * b);


            Console.WriteLine($"{arrayAa}");
            Console.WriteLine($"{arrayA}");
            Console.WriteLine($"{arrayB}");
            Console.WriteLine($"{arrayC}");
        }

        // 2
        static void Select(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray 
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first 
                // element 
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        // 9
        static string Get(List<int> a, List<int> b)
        {


            string r = "=";
            string c = "No";
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == b[i])
                {
                    Console.WriteLine(r);
                }
                else
                {
                    break;
 
                }
            }

            return c;
        }

    }
    
}
