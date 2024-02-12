using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public class PoloShirt
    {
        public Color ShirtColor { get; init; } = Color.Black;

        private uint _quantity = 1;

        //can only buy 1-5 polos
        public uint Quantity
        {
            get => _quantity;
            set
            {
                if (value >= 1 && value <= 5)
                {
                    _quantity = value;
                }
            }
        }

        private decimal _baseCost = 24.99m;

        public decimal Price => _baseCost * Quantity;
    }
}
