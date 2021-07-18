namespace Sum_Matrix_Columns
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int row = input[0];
            int columns = input[1];
            int sum = 0;

            int[,] matrix = new int[row, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int a = 0; a < matrix.GetLength(1); a++)
                {
                    int[] enterNumbers = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    for (int j = 0; j < enterNumbers.Length; j++)
                    {
                        matrix[i, a] = enterNumbers[j];
                        a++;
                    }
                }
            }

            for (int a = 0; a < matrix.GetLength(1); a++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                   sum += matrix[i, a];
                }
                Console.WriteLine(sum);
                sum = 0;
            }

        }
    }
}