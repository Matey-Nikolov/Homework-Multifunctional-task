using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class TextFilter_11
    {
        public string TextFilter1()
        {
            // 11
            //

            Console.Write("Enter a bane words using a comma: ");
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                if (text.Contains(banWord))
                {
                    text = text
                        .Replace(banWord, new string('*', banWord.Length));
                }
            }
            return text;
        }
    }
}
