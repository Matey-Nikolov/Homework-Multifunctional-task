namespace PrintNumbersinReverseOrder
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // 5
            int num = int.Parse(Console.ReadLine());

            int[] numbers = new int[num];

            // 5 - 1
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }

              // numbers = numbers.Reverse().ToArray();
             // Console.WriteLine(string.Join("***", numbers));
            // "5***4***3***2***1"
        }
    }
}
