using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class ReverseText_14
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
