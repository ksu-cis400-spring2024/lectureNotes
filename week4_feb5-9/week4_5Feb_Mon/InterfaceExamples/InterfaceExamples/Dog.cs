using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Dog
    {
        public string Sound()
        {
            return "Woof";
        }

        public int Legs => 4;

        public string Name { get; init; }
    }
}
