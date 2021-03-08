using System;

namespace volleiball
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double Sofia = 0;
            double Sunday = 0;
            double p1 = 0;
            double ob = 0;
            double additional = 0; ;

            Sofia = 48 - h;

            Sofia = Sofia * 3.0 / 4;
            Sunday = h;
            p1 = p * 2.0 / 3;
            ob = Sofia + Sunday + p1;

            switch (name)
            {
                case "leap":
                additional = ob + 0.15 * ob;
                    break;
                case "normal":
                    additional = ob;
                    break;
            }


            Console.WriteLine(Math.Truncate(additional));
        }
    }
}
