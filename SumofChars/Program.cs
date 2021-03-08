namespace SumofChars
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                int currentValue = (int)currentChar;
                sum += currentValue;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
