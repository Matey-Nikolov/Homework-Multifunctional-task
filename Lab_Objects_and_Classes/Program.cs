using System;
using System.Numerics;

namespace Lab_Objects_and_Classes
{
    class Program
    {
        static void Main()
        {
            /*
            // instant
            Dice diceD6 = new Dice();
            diceD6.Sides = 9;

            Dice diceD8 = new Dice(8);

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(diceD6.Roll());
            }
            /*
            // ЗАДАЧА 2 
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
                Console.WriteLine(result);
            }
            */


            
            //ЗАДАЧА 1 от презентацията 

            string[] inputData = Console.ReadLine()
                .Split();

            Random rnd = new Random();

            for (int i = 0; i < inputData.Length; i++)
            {
                string currentElement = inputData[i];
                int rndIndex = rnd.Next(0, inputData.Length); // over would 
                inputData[i] = inputData[rndIndex];
                inputData[rndIndex] = currentElement;
            }

            Console.WriteLine(string.Join(Environment.NewLine, inputData));
            

            //Student student1 = new Student();
            //student1.Name = "Mat";
            //student1.Age = 16;

            //student1.Print();

            //Student student2 = new Student();
            //student2.Name = "Aleko";
            //student2.Age = 15;

            //student2.Print();
            
        }
    }
}
