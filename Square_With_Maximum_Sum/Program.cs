namespace Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] rowCol = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowCol[0];
            int columns = rowCol[1];

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int maxRow = 0;
            int maxCol = 0;
            int maxSum = 0;

            for (int a = 0; a < matrix.GetLength(0) - 1; a++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    int sum = 0;
                    sum = matrix[a, k] + matrix[a, k + 1] + matrix[a + 1, k] + matrix[a + 1, k + 1];

                    if (maxSum < sum)
                    {
                        maxRow = a;
                        maxCol = k;
                        maxSum = sum;
                    }
                }
            }


            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}