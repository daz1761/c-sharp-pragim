using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Classes
{
    partial class MyClass
    {
        public string Creed = "Black";
        public bool Glasses = false;

        public string ShowMessage()
        {
            return "This is a message coming from a method inside one of the partial classes!!!";
        }
    }
}
