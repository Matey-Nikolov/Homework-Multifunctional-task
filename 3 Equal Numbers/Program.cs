using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num == num2 && num == num3 )
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

           
        }
    }
}
