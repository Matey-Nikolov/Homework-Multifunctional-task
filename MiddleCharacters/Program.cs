using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleCharacters(input);
        }

        static void PrintMiddleCharacters(string input)
        {

            if (input.Length % 2 == 0)
            {
                string middle = input[input.Length /2].ToString();

                string middleplus = input[input.Length / 2 - 1].ToString();

                Console.WriteLine($"{middleplus}{middle}");
            }
            else // work
            {
                int middle = input.Length / 2;
                int middle2 = input[middle];
                char middle3 = Convert.ToChar(middle2);

                Console.WriteLine(middle3);
            }
        }
    }
}
