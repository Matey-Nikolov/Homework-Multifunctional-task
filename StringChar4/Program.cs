namespace StringChar4
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            bubbleSort(names);

            for (int i = 0; i < names.Length; i++)
                Console.WriteLine(names[i]);
        }

        static void bubbleSort(string[] name)
        {

            string temp = "";
            bool swapped;

            int Length = name.Length;

            for (int i = 0; i < Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < Length - 1; j++)
                {
                    if (name[j].CompareTo(name[j + 1]) > 0)
                    {
                        temp = name[j];
                        name[j] = name[j + 1];
                        name[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (swapped == false)
                    break;
            }
        }
    }
}