using System;

namespace Упражнения
{
    class Program
    {
        static void Main()
        {
            // 11. Дадено е число n и позиция p. Напишете поредица от операции, 
            // които да отпечатат стойността на бита на позиция p от числото n (0 или 1). 
            // Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0.


            int a = 35;
            int p = 0;
            Console.WriteLine((Convert.ToString(a, 2)));//.PadLeft(32, '0')

            if (Contains(a, p))
                Console.WriteLine('1');
            else
                Console.WriteLine('0');


            // 12. Напишете булев израз, 
            // който проверява дали битът на позиция p на цялото число v има стойност 1. 
            // Пример v=5, p=1 -> false.

            int v = 5;
            int p1 = 1;
            Console.WriteLine((Convert.ToString(v, 2)));

            Console.WriteLine(Contains(v, p1));

            // 13. Дадено е число n, стойност v(v = 0 или 1) и позиция p.
            // Напишете поредица от операции, които да променят стойността на n, така че битът на позиция p да има стойност v. 
            // Пример n = 35, p = 5, v = 0->n = 3.Още един пример: n = 35, p = 2, v = 1->n = 39.

            int n = 35;
            int v1 = 0;
            int p2 = 5;

            int mask = v1 << p2;

            if (v1 == 0)
            {
                Remove(ref n, p2);
            }
            else
            {
                Insert(ref n, p2);
            }


            Console.WriteLine((Convert.ToString(n, 2)));
            Console.WriteLine(n);
        }

        static void Insert(ref int mask, int el)
        {
            mask |= (1 << el); // Съкратен запис.
        }

        static void Remove(ref int mask, int el)
        {
            // mask = mask & ~(1 << el);
            mask &= ~(1 << el);
        }

        static bool Contains(int mask, int el)
        {
            return (mask & (1 << el)) != 0;
        }
    }
}
