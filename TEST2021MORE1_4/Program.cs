namespace TEST2021MORE1_4
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n.ToString().Length];

            for (int i = 0; i < n.ToString().Length; i++)
            {
                num[i] = n.ToString()[i];
            }

            foreach (var item in num)
            {
                Console.WriteLine(string.Join("", (char)item)); // Write
            }
        }
    }
}
