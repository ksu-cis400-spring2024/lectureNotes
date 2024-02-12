using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public class PoloShirt : Shirt
    {
        public PoloShirt()
        {
            _quantity = 1;
            _baseCost = 24.99m;
        }

        public override uint Quantity
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
    }
}
