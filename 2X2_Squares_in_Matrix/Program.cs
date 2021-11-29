using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = rowCol[0];
            int col = rowCol[1];

            string[,] matrix = new string[row, col];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int count = 0;

            for (int a = 0; a < matrix.GetLength(0) - 1; a++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    if ((matrix[a, k] == matrix[a, k + 1]) && (matrix[a + 1, k] == matrix[a + 1, k + 1]))
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}