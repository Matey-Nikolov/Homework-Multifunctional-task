namespace ReadandCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // Инициализирам си речник.
            Dictionary<char, int> textCount = new Dictionary<char, int>();

            // Чета случаен текст.
            string text = Console.ReadLine();

            // Обхождам текста с Foreach.
            foreach (char ch in text)
            {
                // Ако го няма добавям.
                if (!textCount.ContainsKey(ch))
                    textCount.Add(ch, 0);

                textCount[ch]++;
            }
            
            // Принтирам ключа със стойността.
            foreach (var charCount in textCount.OrderBy(x => x.Key))
                Console.WriteLine($"{charCount.Key}: {charCount.Value} time/s");
        }
    }
}
