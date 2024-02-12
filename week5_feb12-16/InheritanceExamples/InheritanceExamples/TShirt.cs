using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public class TShirt : Shirt
    {
        public TShirt()
        {
            _baseCost = 12.99m;
            _quantity = 2;
        }

        private bool _longSleeve = false;
        public bool LongSleeves 
        {
            get => _longSleeve; 
            init 
            {
                if (value == true)
                {
                    _baseCost = 14.99m;
                } 
            } 
        } 

        //only sold in packs of 2
        public override uint Quantity
        {
            get => _quantity;
            set
            {
                if (value >= 2 && value % 2 == 0)
                {
                    _quantity = value;
                }
            }
        }
    }
}
