using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsExample
{
    public class Person
    {
        public string Name { get; }

        public Person(string n)
        {
            Name = n;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
