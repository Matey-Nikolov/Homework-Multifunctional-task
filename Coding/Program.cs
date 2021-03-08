using System;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string str = number.ToString();

            int code = 0;
            char ASCII;


            for (int i = 0; i < str.Length; i++)
            {
                code = number % 10;  //take the last number

                if (code == 0)
                    Console.Write("ZERO");
              
                for (int m = 0; m < code; m++)
                {
                    ASCII = (char)(code + 33);
                    Console.Write(ASCII);
                }
                Console.WriteLine();
                number = (number - code) / 10; // delete last nubber

            }
        }
    }
}
