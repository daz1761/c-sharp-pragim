using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalLibrary.Models;

namespace ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "Darryl";

            Console.WriteLine("{0} has the ID of {1}", employee.Name, employee.ID);
            Console.ReadLine();
        }
    }
}
