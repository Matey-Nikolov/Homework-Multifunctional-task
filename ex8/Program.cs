namespace ex8
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] num = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

           Console.WriteLine(ReturnNum3(num));

        }

        static int[] ReturnNum3(int[] num)
        {
            int[] newnum = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 3 == 0)
                {
                    newnum[i] = num[i];
                }
            }

            foreach (int i in newnum)
            return i[newnum.Length];

        }
    }
}
