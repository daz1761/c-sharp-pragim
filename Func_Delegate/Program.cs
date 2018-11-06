using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ListEmployees = new List<Employee>()
            {
                new Employee {ID = 101, Name = "Callum"},
                new Employee {ID = 102, Name = "Chloe"},
                new Employee {ID = 103, Name = "Olivia"}
            };

            // Func delegate
            Func<Employee, string> selector = employee => "Name = " + employee.Name;

            // the select expects a Func as an arg
            IEnumerable<string> names = ListEmployees.Select(selector);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            // Func is more useful if we want two or more input types, otherwise we could pop a linq query straight in to Select()
            Func<int, int, string> funcDelegate = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();
            Console.WriteLine(funcDelegate(10, 20));

            Console.ReadLine();
        }
    }
}
