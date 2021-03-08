using System;

namespace Задача_побитова
{
    class Program
    {
        static void Main()
        {
            int a = 0;
            int count = 0;
            for (int i = 0; i <= 10; i++)
            {
                string yesOrNo = Console.ReadLine();

                if (yesOrNo == "yes")
                {
                    Insert(ref a, i);
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.WriteLine(Convert.ToString(a, 2));//.PadLeft(32, '0')
           // Console.WriteLine(a);
        }

        static void Insert(ref int mask, int el)
        {
            mask |= (1 << el); 
        }
    }
}