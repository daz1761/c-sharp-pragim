using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            Console.WriteLine(" Field {0}, Field {1}, field {2}, field {3}", myClass.Name, myClass.Age, myClass.Creed, myClass.Glasses);
            Console.WriteLine(myClass.ShowMessage());
            Console.ReadLine();

        }
    }
}
