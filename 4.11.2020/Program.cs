
namespace _4._11._2020
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char searchChar = char.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
               char currentChar = input[i];
                if (currentChar == searchChar)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
