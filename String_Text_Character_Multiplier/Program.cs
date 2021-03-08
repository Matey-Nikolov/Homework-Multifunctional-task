using System;

namespace String_Text_Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            string[] name = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(ReturnSum(name[0], name[1]));
        }

        public static int ReturnSum(string word, string word1)
        {
            int sum = 0;

            if (word.Length > word1.Length)
            {
                string tmp = word;
                word = word1;
                word1 = tmp;
            }

            for (int i = 0; i < word.Length; i++)
            {
                sum += word[i] * word1[i];
            }
            for (int i = 0; i < word1.Length; i++)
            {
                sum += word1[i];
            }
            return sum;
        }
    }
}