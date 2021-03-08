using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 1;
            int lines = 0;


            if (n % 2 == 0)
            {
                stars = 2;
                lines = n / 2;
                Console.Write(new string('-', lines));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', lines));

            }
            else
            {
                stars = 1;
                lines = n / 2 - 1;
                Console.Write(new string('-', lines));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', lines));
            }

            /*  for (int i = 1; i < n / 2; i++) // Размер
              {
                   // Покрив
                   lines = lines - 1;
                    stars = stars + 2;
                   Console.Write(new string("-", lines));
                   Console.Write(new string("*", stars);
                   Console.WriteLine(new string("-", lines));

              }
             */

            for (int k = 0; k < n / 2 - 1; i++)
            {
                // Основа
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');

            }
        }
    }
}
