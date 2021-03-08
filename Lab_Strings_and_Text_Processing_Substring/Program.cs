namespace Lab_Strings_and_Text_Processing_Substring
{
    using System;

    class Program
    {
        static void Main()
        {
            string removeWord = Console.ReadLine().ToLower();
            string words = Console.ReadLine().ToLower();

            int index = words.IndexOf(removeWord);

            while (index != -1)
            {
                words = words.Remove(index, removeWord.Length);
                index = words.IndexOf(removeWord);
            }

            Console.WriteLine(words);
        }
    }
}