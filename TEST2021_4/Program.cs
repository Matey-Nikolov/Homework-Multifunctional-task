using System;

namespace TEST2021_4
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var ch = new Random();

            for (int i = 0; i < n; i++)
            {
                ch[i] = Random.Next('a', 'z');
            }
        }
    }
}
