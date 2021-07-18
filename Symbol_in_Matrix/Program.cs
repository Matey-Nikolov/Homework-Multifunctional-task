namespace Symbol_in_Matrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[,] symbol = new char[n, n];

            for (int i = 0; i < symbol.GetLength(0); i++)
            {
                char[] input = Console.ReadLine()
                    .ToString()
                    .ToCharArray();

                for (int j = 0; j < input.Length; j++)
                {
                    symbol[i, j] = input[j];
                }    
            }

            char findItem = char.Parse(Console.ReadLine());

            for (int row = 0; row < symbol.GetLength(0); row++)
            {
                for (int col = 0; col < symbol.GetLength(1); col++)
                {
                    if (symbol[row, col] == findItem)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{findItem} does not occur in the matrix");
        }
    }
}