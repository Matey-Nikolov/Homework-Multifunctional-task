using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            LowerLetters('A');
        }

        static void LowerLetters(char ch)
        {
            string a = ch.ToString().ToLower();
            Console.WriteLine(char.Parse(a));
        }
    }
}
