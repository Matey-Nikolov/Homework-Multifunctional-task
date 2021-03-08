using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class ReverseString_2
    {
        public string Revererse()
        {
            // 2
            // 
            Console.Write("Enter a string while enter end: ");
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