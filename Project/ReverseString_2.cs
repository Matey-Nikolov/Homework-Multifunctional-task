using System;
using System.Text;

namespace Project
{
    class ReverseString_2
    {
        public string Revererse()
        {
            // 2
            // 
            Console.Write("Enter a string: ");
            string line = Console.ReadLine();
            string reversed = "";

            for (int i = line.Length; i > 0; i--)
            {
                reversed += line[i - 1];
            }
            
            return reversed;
        }
    }
}