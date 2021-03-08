namespace Test2021Подготовка3
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            /*
            string[] words = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> wc = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!wc.ContainsKey(word))
                {
                    wc.Add(word, 1);
                }
                else
                {
                    wc[word]++;
                }
            }

            foreach (var el in wc)
            {
                Console.WriteLine($"{el.Key} -> {el.Value}");
            }
            */

            Console.WriteLine(Ending5(5115555)); // 4 
        }

        static int CountDidit5(int num)
        {
            int cnt = 0;
            while (num != 0)
            {
                int gigit = num % 10;
                if (gigit == 5)
                {
                    cnt++;
                }
                num /= 10;
            }
            return cnt;
        }

        static int Ending5(int number)
        {
            int cnt = 0;
            while(number != 0)
            {
                int gigit = number % 10;
                if (gigit == 5)
                {
                    cnt++;
                }
                else
                {
                    break;
                }
                number /= 10;
            }
            return cnt;
        }
    }
}
