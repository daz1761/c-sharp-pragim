using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance =
                new
                {
                    // these types are inferred be the compiler
                    FirstName = "Darryl",
                    LastName = "Griffiths",
                    Age = 41,
                    GPA = 4.0
                };

            // if we try and change these props we can't because this anonymous object is immutable
            // instance.LastName = "Hughes"

            Console.WriteLine("{0} {1} {2} {3}", instance.LastName, instance.FirstName, instance.Age, instance.GPA);
        }
    }
}
