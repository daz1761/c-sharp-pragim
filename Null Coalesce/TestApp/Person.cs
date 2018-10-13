using System;
using System.Collections.Generic;
using System.Text;
using Kids;

namespace People
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Children children = new Children();
    }
}
