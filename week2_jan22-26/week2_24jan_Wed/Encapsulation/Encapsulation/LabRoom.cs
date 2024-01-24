using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class LabRoom
    {
        private int _computers = 20;
        public int Computers
        {
            get => _computers;
            set
            {
                if (value >= 10 && value <= 30)
                {
                    _computers = value;
                }
            }
        }

        public bool Windows { get; init; } = true;

        public static bool DrinksAllowed { get; set; }

        static LabRoom()
        {
            DrinksAllowed = false;
        }
    }
}
