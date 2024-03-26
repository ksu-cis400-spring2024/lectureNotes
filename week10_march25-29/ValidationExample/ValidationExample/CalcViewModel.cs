using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class CalcViewModel
    {

        private uint _shirts = 0;
        public uint Shirts
        {
            get => _shirts;
            set
            {
                _shirts = value;

                //throw exception if #shirts is invalid (more than 10)

                //how to make sure cost is updated on GUI?
            }
        }

        public decimal Cost
        {
            get
            {
                //$10 per shirt for up to 5 shirts, $8 per shirt after that
                throw new NotImplementedException();
            }
        }
    }
}
