
namespace AddandSubtract
{
    using System;

    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Sum(n1, n2);
            int a = Sum(n1, n2);
            Subtract(n3, a);
        }

        static void Subtract(int n3, int a)
        {
            int sum =  a - n3;
            Console.WriteLine(value: sum);
        }

        static int Sum(int n1, int n2)
        {
            int sumn1n2 = 0;

            return sumn1n2 = n1 + n2;
        }
    }
}
