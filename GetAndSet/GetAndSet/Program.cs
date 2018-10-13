using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAndSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // get set is part of one of the four pillars of OOP - Encapsulation
            Student C1 = new Student();
            C1.Age = 11;
            C1.Age2 = -11;

            Console.WriteLine("The age of this horrible kid is {0}", C1.Age2);
            Console.ReadLine();
        }
    }

    public class Student
    {
        // we need to drop the public access modifier
        private int _age;
        private int _age2;
        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // lets restrict negative numbers
        public int Age2
        {
            get { return _age2; }
            set
            {
                if (value >= 0)
                {
                    _age2 = value;
                }
            }
        }   
    }

    // more from Stack Overflow
    public class Genre
    {
        private string name; // This is the backing field
        public string Name   // This is your property
        {
            get => name;
            set => name = value;
        }
    }

    // more from Stack Overflow
    public class YourName
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }

    // so when you declare the shorthand: "public string Name { get; set; }" the compiler generates the above two examples from Stack Overflow
}
