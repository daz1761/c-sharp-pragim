using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Mark"},
                new Employee{ ID = 102, Name = "John"},
                new Employee{ ID = 103, Name = "Mav"}
            };

            // lambda method is more convenient than an anonomous method (see delegate)
            Employee employee = listEmployees.Find(x => x.ID == 102);

            // can be explicitly defined but not needed as they are inferred
            Employee employee2 = listEmployees.Find((Employee x) => x.ID == 103);

            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);
            Console.WriteLine("ID = {0}, Name = {1}", employee2.ID, employee2.Name);
            Console.ReadLine();

        }
    }

    public class Employee
    {
        public int ID;
        public string Name;
    }
}
