using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEnurmerable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oyears = new List<int>();
            oyears.Add(1990);
            oyears.Add(1991);
            oyears.Add(1992);
            oyears.Add(1993);
            oyears.Add(2001);
            oyears.Add(2002);
            oyears.Add(2003);

            // IEnumerable actually uses IEnumerator
            // IEnumerable actually makes the syntax shorter and sweeter
            // IEnumerable does not remember the cursor state i.e. the index position when passing to multiple functions
            IEnumerable<int> iEnum = (IEnumerable<int>)oyears; // cast list to iEnumerable

            foreach (int i in iEnum)
            {
                Console.WriteLine(i);
            }

            IEnumerator<int> iEnumerator = oyears.GetEnumerator();

            while (iEnumerator.MoveNext())
            {
                Console.WriteLine(iEnumerator.Current.ToString());
            }

            Console.ReadLine();
        }
    }
}
