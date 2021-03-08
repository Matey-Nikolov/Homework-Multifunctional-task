using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class ReplaceChar
    {
        public StringBuilder Relace()
        {
            Console.Write("Enter a string of letters: ");
            string doc = Console.ReadLine();
          //  string doc = "aaaaabbbbbcdddeeeedssaa";

            StringBuilder sb = new StringBuilder();
            char current = doc[0];
            sb.Append(current);

            for (int i = 1; i < doc.Length; i++)
            {
                if (current != doc[i])
                {
                    current = doc[i];
                    sb.Append(current);
                }
            }

            return sb;
        }
    }
}
