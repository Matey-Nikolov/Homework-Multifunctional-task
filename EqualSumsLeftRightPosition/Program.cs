using System;

namespace EqualSumsLeftRightPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
            {
            string ni = i.ToString();

            int left = int.Parse(ni[0].ToString()) + int.Parse(ni[1].ToString());
            int right = int.Parse(ni[3].ToString()) + int.Parse(ni[4].ToString());

            int nmin = Math.Min(left, right) + int.Parse(ni[2].ToString());

            if (left == right)
                    Console.Write($"{i} ");
            else if (nmin == Math.Max(left, right))
                        Console.Write($"{i} ");
            }
        }
    }
 }