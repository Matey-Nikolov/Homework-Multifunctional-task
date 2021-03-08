using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Unicoe_8
    {
        public static void ReturnUnicode()
        {
            // 8
            //
            Console.WriteLine("Enter a word in Bulgarian.");
            string word = Console.ReadLine();


            for (int i = 0; i < word.Length; i++)
                Console.Write(@"\u{0:X4}", Convert.ToInt16(word[i]));
        }

    }
}
