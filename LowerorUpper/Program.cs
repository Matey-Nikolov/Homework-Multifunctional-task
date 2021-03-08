
namespace LowerorUpper
{
    using System;

    class Program
    {
        static void Main()
        {
            char ch = char.Parse(Console.ReadLine());
        
            IsLowerorIsUpper(ch);
        }

        private static void IsLowerorIsUpper(char ch)
        {
            if ((ch >= 'a') && (ch <= 'z'))
            {
                Console.WriteLine("lower-case");
            }
            else if ((ch >= 'A') && (ch <= 'Z'))
            {
                Console.WriteLine("upper-case");
            }

            
        }
    }
}
