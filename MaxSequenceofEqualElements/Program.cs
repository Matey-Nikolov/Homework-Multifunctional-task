namespace MaxSequenceofEqualElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {/*
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    num1 = i;
                }

                if (num1 > num2)
                {
                    Console.Write(num1);
                }

            }
            */



            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            int winningCounter = 0;
            int index = 0;
            string number = string.Empty;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (counter > winningCounter)
                    {
                        winningCounter = counter;
                        index = i;
                        number = numbers[i].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= winningCounter; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
    }
}
