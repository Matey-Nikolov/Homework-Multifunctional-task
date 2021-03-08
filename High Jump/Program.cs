using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int TargetGoal = int.Parse(Console.ReadLine());
            int currentHeight = TargetGoal - 30;

            int jumpsAll = 0;
            int jumpsFail = 0;
            int jump = 0;

            while (true)
            {
                jump = int.Parse(Console.ReadLine());
                jumpsAll++;

                if (jump <= currentHeight)
                {
                    jumpsFail++;
                    if (jumpsFail == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {currentHeight}cm after {jumpsAll} jumps.");
                        break;
                    }
                }
                else if (currentHeight >= TargetGoal)
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {TargetGoal}cm after {jumpsAll} jumps.");
                    break;
                }
                else
                {
                    jumpsFail = 0;
                    currentHeight += 5;
                }
     
            }
        }
    }
}
