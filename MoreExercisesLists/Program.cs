namespace MoreExercisesLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<char> text = Console.ReadLine()
                .ToCharArray()
                .ToList();

            string result = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                char[] currentDigits = currentNumber.ToString().ToCharArray();
                int sum = 0;

                for (int g = 0; g < currentDigits.Length; g++)
                {
                    sum += int.Parse(currentDigits[g].ToString());
                }

                int index = sum % text.Count;

                result += text[index];
                text.RemoveAt(index);
            }
            Console.WriteLine(result);
        }
    }
}
