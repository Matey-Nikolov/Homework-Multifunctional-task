using System;

namespace Побитова_операция_2
{
    class Program
    {
        static void Main()
        {
            /*
            Операция с ~

            int num = 1670;
            int result = ~num; // нулите стават 1, 1 стават нули
            Console.WriteLine("num = " + Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("res = " + Convert.ToString(result, 2).PadLeft(32, '0'));
            */
            /*
            Операция с &, |

            int a = 345;
            int b = 287;
            int c = a | b; // & 
            Console.WriteLine(c);
            Console.WriteLine("a = " + Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine("b = " + Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine("c = " + Convert.ToString(c, 2).PadLeft(32, '0'));
            */
            /*
            Операция с ^

            int a = 345;
            int b = 287;
            int c = a ^ b; 
            Console.WriteLine(c);
            Console.WriteLine("a = " + Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine("b = " + Convert.ToString(b, 2).PadLeft(32, '0'));
            Console.WriteLine("c = " + Convert.ToString(c, 2).PadLeft(32, '0'))
            */
            /*
            // Операция с <<, >>
            int a = 345;
            int c = a >> 3;
            Console.WriteLine(c);
            Console.WriteLine("a = " + Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine("c = " + Convert.ToString(c, 2).PadLeft(32, '0'));
            */

            int a = 10;
            Console.WriteLine(Convert.ToString(a, 2).PadLeft(32, '0'));
            Console.WriteLine(Insert(a, 2));
        }

        static bool Contains (int mask, int el)
        {
            if ((mask & (1 << el)) != 0)
            {
                return true;
            }
            return false;
        }

        static void Insert(ref int mask, int el)
        {
             mask |= (1 << el);
        }
    }
}