using System;

namespace побитови
{
    class Program
    {
        static void Main()
        {
            int a = 12345879;
            int b = 23432443;
            int c = a >> 9;
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32,'0'));
            //Console.WriteLine(Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(c, 2).PadLeft(32, '0'));
        }
    }
}