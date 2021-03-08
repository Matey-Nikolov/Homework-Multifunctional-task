using System;

namespace _06._01._2021
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int sum1 = 0;

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine().ToLower();

                for (int a = 0; a < name.Length; a++)
                {

                    if (name[a] == 'a' || name[a] == 'e' || name[a] == 'u' || name[a] == 'o' || name[a] == 'i')
                    {
                        sum += name[a] * name.Length;
                    }
                    else
                    {
                        sum1 += name[a] / name.Length;
                    }

                }
                
                array[i] = sum + sum1;
                sum = 0;
                sum1 = 0;
            }

            Array.Sort(array);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
