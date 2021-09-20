namespace Snake_Moves
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] nM = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = nM[0];
            int m = nM[1];

            char[,] matrix = new char[n, m];

            string snake = Console.ReadLine();
            int x = -1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (x == snake.Length - 1)
                            x = -1;

                        x++;
                        matrix[i, j] = snake[x];
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (x == snake.Length - 1)
                            x = -1;

                        x++;
                        matrix[i, j] = snake[x];
                    }
                }
            }

            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int l = 0; l < matrix.GetLength(1); l++)
                {
                    Console.Write($"{matrix[k, l]}");
                }
                Console.WriteLine();
            }
        }
    }
}