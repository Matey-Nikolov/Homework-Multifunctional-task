using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Objects_and_Classes
{
    class Student
    {
        public Student()
        {

        }
        
        private string fullName;

        public string FullName
        {
            get { return this.fullName + " " + this.LastName; }
            set { this.fullName = value; }
        }
        
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine($"I am {FullName} and I am {Age} years old");
        }
    }
}
