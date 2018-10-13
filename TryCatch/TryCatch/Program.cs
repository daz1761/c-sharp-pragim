using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 0;
                int y = 7 / x; // cant divide by 0
            }
            // ex is an object
            catch(Exception ex)
            {
                // we can put anything we want here - in work we normally log it to a file "logger"
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
