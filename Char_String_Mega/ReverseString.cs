using System;
using System.Collections.Generic;
using System.Text;

namespace Char_String_Mega
{
    class ReverseString
    {
        public string Revererse()
        {
            // 2
            // 
            Console.Write("Enter a one string: ");
            string line = Console.ReadLine();
            string reversed = "";
            while (line != "end")
            {
                line = Console.ReadLine();

                for (int i = line.Length; i > 0; i--)
                {
                    reversed += line[i - 1];
                }
            }
            return reversed;
        }
    }
}