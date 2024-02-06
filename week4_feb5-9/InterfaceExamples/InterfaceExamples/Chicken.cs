using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Chicken : IAnimal
    {
        
        public string Sound()
        {
            return "Cluck";
        }

        public uint Legs { get; set; } = 2;
    }
}
