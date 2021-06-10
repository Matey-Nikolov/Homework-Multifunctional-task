namespace MaximumAndMinimumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            if (1 <= n && n <= 105)
            {
                for (int i = 0; i < n; i++)
                {
                    int[] typeNum = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    int type = typeNum[0];
                    int num = 0;

                    if (typeNum.Length == 2)
                        if (1 <= typeNum[1] && typeNum[1] <= 109)
                            num = typeNum[1];

                    if (1 <= type && type <= 4)
                    {
                        switch (type)
                        {
                            case 1:
                                numbers.Push(num);
                                break;
                            case 2:
                                if (numbers.Count == 0)
                                    continue;

                                numbers.Pop();
                                break;
                            case 3:
                                if (numbers.Count == 0)
                                    continue;
                                
                                int maxNum = numbers.Max();
                                Console.WriteLine(maxNum);
                                break;
                            case 4:
                                if (numbers.Count == 0)
                                    continue;

                                int minNum = numbers.Min();
                                Console.WriteLine(minNum);
                                break;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}