namespace ArrayRotation
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] arrays = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            int n = int.Parse(Console.ReadLine());

            int count = arrays[0];

            for (int i = 0; i < arrays.Length; i++)
            {
                for (int a = 0; a < arrays.Length - 1; a++)
                {
                    arrays[a] = arrays[a + 1];
                }
                count = arrays[arrays.Length - 1];

                Console.WriteLine(string.Join(" ", count));
            }

        }
    }
}
