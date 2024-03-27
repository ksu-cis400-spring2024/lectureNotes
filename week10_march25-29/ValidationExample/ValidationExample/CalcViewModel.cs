using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class CalcViewModel : INotifyPropertyChanged
    {

        private uint _shirts = 0;
        public uint Shirts
        {
            get => _shirts;
            set
            {
                _shirts = value;

                //throw exception if #shirts is invalid (more than 10)
                if (_shirts > 10)
                {
                    _shirts = 0;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shirts)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cost)));
                    throw new ArgumentException("shirts should be <=10");
                }
                else
                {
                    //how to make sure cost is updated on GUI?
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shirts)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cost)));
                }
                
            }
        }

        public decimal Cost
        {
            get
            {
                //$10 each for up to 5 shirts, $8 each for more than 5
                if (Shirts <= 5) return Shirts * 10.00m;
                else return Shirts * 8.00m;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
