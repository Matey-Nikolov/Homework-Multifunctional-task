namespace ex1._2
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (n > m)
            {
                int temp = n;
                n = m;
                m = temp;
            }

            Random rand = new Random();

            int[] num = new int[100];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", rand.Next(n, m));
            }


        }
    }
}
