
namespace Типоведанни3
{
    using System;

    class Program
    {
        static void Main()
        {
            // char ch = '%';
            // Console.WriteLine((int)ch); // 37
            // char ch1 = 'B';
            // Console.WriteLine((int)ch1); // 66

            Console.WriteLine(Tolower('t')); // char.ToLower, char.IsUpper

        }

        static bool IsLower(char ch)
        {
            return (ch >= 'a') && (ch <= 'z'); // 97, 122
        }

        static bool IsUpper(char ch)
        {
            return (ch >= 'A') && (ch <= 'Z'); // 65, 90
        }

        static bool IsLetter(char ch)
        {
            return IsLower(ch) || IsUpper(ch);  // ((ch >= 'a') && (ch <= 'z')) || ((ch >= 'A') && (ch <= 'Z'));
        }

        static int CharToInt(char ch)
        {
            return (int)ch - '0'; // 48
        }

        static char Tolower(char ch)
        {
            // return (char)((int)ch + 32);

            if (IsUpper(ch))
            {
                return (char)((int)ch + ('a' - 'A')); // ('a' - 'A') = 32
            }
            return ch;
        }


    }
}
