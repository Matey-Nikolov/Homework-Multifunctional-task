using System;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Maria";
            string lastName = "Ivanova";
            int age = 19;
            string str = firstName + " " + lastName + " @ " + age;
            Console.WriteLine(str);

 //          double a = 1.5;
  //          double b = 2.5;
      //      string sum = "The sum is: " + a + b;
    //        Console.WriteLine(sum);
           
          int side = int.Parse(Console.ReadLine());
            int area = side * side;

            Console.WriteLine(area);

            double inches = double.Parse(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine(centimeters);

        }
    }
}
