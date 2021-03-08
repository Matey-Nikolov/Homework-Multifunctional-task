namespace _27._10._2020
{
    using System;

    class Program
    {
        static void Main()
        {
            int a = 10;
            increment(ref a);
            Console.WriteLine("n = {0}", a);


            int n = 10;
            int m = 100;
            Console.WriteLine("n = {0}, n = {1}", n, m);
            Swap(ref n, ref m);
            Console.WriteLine("n = {0}, n = {1}", n, m);
        }

        static void increment( ref int num)
        {
            num++;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = 0;
            a = b;
            b = temp;
        }

    }
}
