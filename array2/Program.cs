namespace array2
{
    using System;

    class Program
    {
        static void Main()
        {   
            int[] arr = new int[10]; // FIX size
            int i = 0;
            

            while (true)
            {
                int num = int.Parse(Console.ReadLine());

                if (num == -1)
                {
                    break;
                }

                arr[i] = num;
                i++;
            }

            Array.Sort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }



    }
}
