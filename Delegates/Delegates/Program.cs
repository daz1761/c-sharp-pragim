using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this delegate signiture can point to any function that has VOID return and takes a STRING as an argument 
public delegate void HelloFunctionDelegate(string Message); // we can point to a function that has a similar syntax

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // A delegate is a type safe function pointer - meaning it points to a function and when you invoke this delegate the function will be invoked.
            // we have to make an instance of the delegate
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate");

            void Hello(string strMessage)
            {
                Console.WriteLine(strMessage);
                Console.ReadLine();
            }
        }
    }
}
