using System;
using System.Text;

namespace Lab_Strings_and__Text_Processing_Repeat_Strings
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                int count = word.Length;

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }

            }

            Console.WriteLine(result);
        }
    }
}