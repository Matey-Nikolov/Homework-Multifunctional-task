using System;
using System.Text;

namespace Char_String_Mega
{
    class ReverseText
    {
        public string Reverse()
        {
            Console.Write("Enter a text: ");
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder text1 = new StringBuilder();

            for (int i = text.Length; i > 0; i--)
            {
                text1.Append(text[i - 1]);
            }

            return text1.ToString();
        }
    }
}