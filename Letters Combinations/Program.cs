using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            char code1;
            char code2;
            char code3;

            int number = 0;

            for (char i = letter1; i <= letter2; i++)
            {
                if (i != letter3)
                {
                    code1 = i;
                }
                else
                {
                    continue;
                }

                for (char a = letter1; a <= letter2; a++)
                {
                    if (a != letter3)
                    {
                        code2 = a;
                    }
                    else
                    {
                        continue;
                    }


                    for (char b = letter1; b <= letter2; b++)
                    {
                        if (b != letter3)
                        {
                            code3 = b;
                            number++;
                            Console.Write($"{code1}{code2}{code3} ");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
           Console.Write($"{number}");
        }
    }
}
