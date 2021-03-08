using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class CountSubstring_5
    {
        public string CountSubstring()
        {
            // 5
            //
            Console.Write("Enter a remove word: ");
            string removeWord = Console.ReadLine().ToLower();
            Console.Write("Enter a words: ");
            string words = Console.ReadLine().ToLower();

            int index = words.IndexOf(removeWord);

            while (index != -1)
            {
                words = words.Remove(index, removeWord.Length);
                index = words.IndexOf(removeWord);
            }

            return words;
        }
    }
}