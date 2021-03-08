using System;
using System.Collections.Generic;
using System.Text;

namespace Char_String_Mega
{
    class TextFilter
    {
        public string TextFilter1()
        {
            // 11
            //

            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

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
