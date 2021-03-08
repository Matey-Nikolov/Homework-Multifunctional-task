namespace EqualSums
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] arraynumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int oddeven = arraynumbers.Length;

            int left = 0;
            int right = 0;
            int ewew = 0;

            for (int i = 0; i < arraynumbers.Length / 2 - 1; i++)
            {
                left = arraynumbers[i] + arraynumbers[i + 1];

                Console.WriteLine(left);

                for (int a = 0; a < arraynumbers.Length / 2 - 1; a++)
                {
                    right = arraynumbers[a] + arraynumbers[a + 1];
                }

                ewew++;
                Console.WriteLine(right);
            }
            if (left == right)
            {
                
            }
        }
    }
}
