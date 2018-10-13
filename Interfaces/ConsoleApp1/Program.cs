using System;

namespace ConsoleApp1
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Interface Print Method");
        }

        public void Print2()
        {
            Console.WriteLine("I2 Print Method");
            Console.ReadLine();
        }
    }

    class Sample
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print1();
            C1.Print2();

            // we can do this too which is a bit mind blowing
            ICustomer1 Cust = new Customer();
            Cust.Print1();
            // because ICustomer1 is a parent to ICustomer2, and this is the parent of Customer, we can reference it when we instantiate a Customer instance
            // however, we can only have access to the Print1() function - think about it!
        }
    }
}
