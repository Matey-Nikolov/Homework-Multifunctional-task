using System;
using System.Collections.Generic;
using System.Text;

namespace Char_String_Mega
{
    class _8_Unicode
    {
        public static void Unicode()
        {
            // 8
            //
            Console.Write("Enter a word in Bulgarian: ");
            string word = Console.ReadLine();


            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(@"\u{0:X4}", Convert.ToInt16(word[i]));
            }
        }
    }
}