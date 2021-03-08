using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class LongString_7
    {
        public string Text()
        {
            // 7
            //
            Console.Write("Enter a string not londer 20: ");
            string str = Console.ReadLine();
            string a = "";
            int length = str.Length;

            if (length > 20)
            {
                Console.Write("Try again: ");
                str = Console.ReadLine();
                length = str.Length;

                if (length < 20)
                    Console.WriteLine(str.PadRight(20, '*'));
                else if (length == 20)
                    Console.WriteLine(str);
            }
            else if (length < 20)
                Console.WriteLine(str.PadRight(20, '*'));
            else if (length == 20)
                a = $"The word is exactly 20 characters: {str}.";

            return a;
        }
    }
}
