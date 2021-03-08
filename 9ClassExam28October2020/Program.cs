namespace _9ClassExam28October2020
{
    using System;

    class Program
    {
        static void Main()
        {
            string abc = Console.ReadLine();

            CalculateCountOfVowels(abc);
            int a = CalculateCountOfVowels(abc);
            PrintResult(a);
        }

        static void PrintResult(int a)
        {
            Console.WriteLine(a);
        }

        static int CalculateCountOfVowels(string abc)
        {
            int sum = 0;
            int total = 0;

            for (int i = 0; i < abc.Length; i++)
            {

                sum = abc[i];

                switch (sum)
                {
                    case 'a':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'e':
                    case 'A':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'E':
                        total++;
                        break;
                }

            }
            return total;
        }
    }
}
