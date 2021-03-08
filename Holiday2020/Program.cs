namespace Holiday2020
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<char> input = Console.ReadLine()
                .ToCharArray()
                .ToList();
            /*
            List<int> numbers = input
                .Where(el => char.IsDigit(el))
                .Select(el => int.Parse(el.ToString()))
                .ToList();
            */
            List<int> numbers = new List<int>();
            List<char> text = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentDigit = 0;
                if (Int32.TryParse(input[i].ToString(), out currentDigit))
                {
                    numbers.Add(currentDigit);
                }
                else
                {
                    text.Add(input[i]);
                }
            }

            List<char> result = new List<char>();

            for (int i = 0; i < numbers.Count; i += 2)
            {
                result = text.Take(numbers[i]).ToString().ToList();  //Take(numbers[i]).ToString();
                int skip = numbers[i] + numbers[i + 1];
                text.RemoveRange(0, skip);
            }

                Console.WriteLine(string.Join(' ', text));

        }
    }
}
