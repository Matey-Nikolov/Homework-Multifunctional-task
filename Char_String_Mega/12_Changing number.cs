using System;
using System.Collections.Generic;
using System.Text;

namespace Char_String_Mega
{
    class _12ChangingNumber
    {
        public static void Ejknf()
        {
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("000000000111111");
            Console.WriteLine("123456789012345");
            Console.WriteLine("{0,15:D}", number.ToString("D"));
            Console.WriteLine("{0,15}", Convert.ToDouble(number));
            Console.WriteLine("{0,15:E}", Convert.ToDouble(number));
            Console.WriteLine("{0,15:C}", Convert.ToDouble(number));
            Console.WriteLine("{0,15:X}", Convert.ToInt32(number));
            Console.WriteLine("{0,15:P}", Convert.ToInt32(number));

        }
    }
}
