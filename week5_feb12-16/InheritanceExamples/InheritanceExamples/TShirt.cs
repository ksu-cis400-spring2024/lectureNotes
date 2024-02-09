using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public class TShirt
    {
        public Color ShirtColor { get; init; } = Color.Black;

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

        private uint _quantity = 2;

        //only sold in packs of 2
        public uint Quantity
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

        private decimal _baseCost = 12.99m;

        public decimal Price => _baseCost * Quantity;
    }
}
