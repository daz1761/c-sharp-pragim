using System;
using People;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = null;
            string str2 = null;
            string str3 = null;
            string str4 = "Hello";

            // null coalescing operator
            string final = str1 ?? str2 ?? str3 ?? str4;

            // if str4 is null - final is null and wont be printed
            Console.WriteLine(final);
            Console.WriteLine(final.GetType());

            // non nullable types have a default
            // nullable types are null as default
            
            int? foo = null; // nullable
            int bar = 0;     // non-nullable

            // we cant assign nullable to non-nullable so we need the .Value which returns a non-nullable counterpart
            foo = 3; // but before we can do this we must give foo a value
            bar = foo.Value;
            Console.WriteLine("foo = {0}", foo);

            // or cast it (implicit and explicit conversion) 
            bar = (int)foo;

            // or instead of lots of if/else's use a null coalescing operator
            int? ticketsOnSale = null; ;

            int availableTickets = ticketsOnSale ?? 0; // this will be 0 unless ticketsOnSale is given a value;

            Console.WriteLine("Available number of tickets is {0}", availableTickets);

            // null propagating operator with objects and properties
            Person darryl = new Person { Name = "Darryl Griffiths" };
            //darryl.children.Name = "Daz";
            Console.Write("First Child: ");
            Console.WriteLine(darryl.children?.Name ?? "-"); // prop through the chain and output "-" is no name
            Console.ReadLine();

        }
    }
}
