using System;

namespace преговор1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;

            for (int i = 0; i < n; i++)
            {
                int nright = int.Parse(Console.ReadLine());
                right = nright + right;
            }

            for (int a = 0; a < n; a++)
            {
                int nleft = int.Parse(Console.ReadLine());
                left = nleft + left;
            }

            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else if (left != right)
            {
                int diff = 0;
                diff = left - right;
                Console.WriteLine($"No, diff = {Math.Abs(diff)}");
            }
            else if (right != left)
            {
                int diff1 = 0;
                diff1 = right - left;
                Console.WriteLine($"No, diff = {Math.Abs(diff1)}");
            }
        }
    }
}
