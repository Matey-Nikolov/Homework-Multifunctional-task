namespace StringChar_2_0_3
{
    using System;

    class Program
    {
        static void Main()
        {
            //string text = "Hello. C# I'm from C# Pravets! I'm C# developer!";
            //  Console.WriteLine(Contains(text, "C#"));
            // Console.WriteLine(text.LastIndexOf("C#"));
            //Console.WriteLine(text.IndexOf("Геввд", 1));

            string text = Console.ReadLine();
            string word = Console.ReadLine();

            Console.WriteLine(WordsCount(text, word));
        }

        static bool Contains(string text, string word)
        {
            return text.IndexOf(word) != -1;
        }

        static int WordsCount(string text, string word)
        {
            int count = 0;

            int index = text.IndexOf(word);

            while(index != -1)
            {
                count++;
                index = text.IndexOf(text, index + 1);
            }
            return count;
        }
    }
}