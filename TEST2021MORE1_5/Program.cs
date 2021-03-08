namespace TEST2021MORE1_5
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            string num = number.ToString();
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == '8')
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
