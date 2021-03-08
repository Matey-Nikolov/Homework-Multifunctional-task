using System;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("{0} {1}", i, j);
                    if (i == 5 && j == 5)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }
    }
}
