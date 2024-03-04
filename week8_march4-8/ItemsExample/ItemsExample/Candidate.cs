using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsExample
{
    public class Candidate : INotifyPropertyChanged
    {
        public string Name { get; }

        private uint _votes = 0;
        public uint Votes
        {
            get => _votes;
            set
            {
                _votes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Votes)));
            }
        }

        public Candidate(string n)
        {
            Name = n;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
