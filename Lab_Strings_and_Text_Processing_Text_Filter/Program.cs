namespace Lab_Strings_and_Text_Processing_Text_Filter
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                //if (text.Contains(banWord))
                //{
                    text = text
                        .Replace(banWord, new string('*', banWord.Length));
                //}
            }
            Console.WriteLine(text);
        }
    }
}