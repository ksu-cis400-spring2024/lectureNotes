using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Dog : IAnimal
    {
        public string Sound()
        {
            return "Woof";
        }

        public void Print()
        {
            Console.WriteLine(Sound());
        }

        public uint Legs { get; set; } = 4;

        public string Name { get; set; }

        public uint Age { get; set; }

        public uint PeopleYears
        {
            //this is unfinished

            //0 dog -> 0 person
            //1 dog -> 15 person
            //2 dog -> 24 person
            //3 dog -> 29 

            get
            {
                if (Age == 0) return 0;
                else if (Age == 1) return 15;
                else if (Age == 2) return 24;
                else return 24 + 5 * (Age - 2);
            }
        }
    }
}
