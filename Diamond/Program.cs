using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;

            Console.Write(new string('-', leftRight));
            if (mid<0)
              Console.Write(new string('*', 1));
            else
                Console.Write(new string('*', 2));
            Console.WriteLine(new string('-', leftRight));

            if (n == 1) 
                return;
           
             for(int i=0;i<  n/2;i++)
            {
                leftRight = leftRight - 1;
                mid = n - 2 * leftRight - 2;
                if (leftRight < 0)
                    break;
                Console.Write(new string('-', leftRight));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', mid));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', leftRight));
            }


            leftRight = 0;
            for (int i=1;i<n/2;i++) {
                leftRight = leftRight + 1;
                mid = n - 2 * leftRight - 2;
                if (mid < 0) break;
                Console.Write(new string('-', leftRight));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', mid));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', leftRight));
            }
            if (n%2!=0) { 
            leftRight = (n - 1) / 2;
            mid = n - 2 * leftRight - 2;
            Console.Write(new string('-', leftRight));
            if (mid < 0)
                Console.Write(new string('*', 1));
            else
                Console.Write(new string('*', 2));
            Console.WriteLine(new string('-', leftRight));
            }
        }
    }
}
