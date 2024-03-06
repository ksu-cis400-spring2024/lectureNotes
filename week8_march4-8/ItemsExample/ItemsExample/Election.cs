using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsExample
{
    public class Election : ICollection<Candidate>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private List<Candidate> _candidates = new();

        public Candidate? Winner
        {
            get
            {
                Candidate? best = null;
                foreach (Candidate c in _candidates)
                {
                    if (best == null || c.Votes > best?.Votes)
                    {
                        best = c;
                    }
                }

                return best;
            }
        }

        public int Count => _candidates.Count;

        public uint TotalVotes
        {
            get
            {
                uint total = 0;
                foreach (Candidate c in _candidates)
                {
                    total += c.Votes;
                }

                return total;
            }
        }

        public bool IsReadOnly => false;

        public event NotifyCollectionChangedEventHandler? CollectionChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        //I want this method to run whenever a candidate's votes change
        private void HandleVoteChange(object? sender, PropertyChangedEventArgs e)
        {

            //this is called because a candidate's votes changed
            //so I announce that my TotalVotes changed
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotalVotes)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Winner)));
        }

        public void Add(Candidate item)
        {
            _candidates.Add(item);

            //listen to changes in item
            item.PropertyChanged += HandleVoteChange;

            //want to invoke CollectionChanged
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
        }

        public void Clear()
        {
            _candidates.Clear();
        }

        public bool Contains(Candidate item)
        {
            return _candidates.Contains(item);
        }

        public void CopyTo(Candidate[] array, int arrayIndex)
        {
            _candidates.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Candidate> GetEnumerator()
        {
            return _candidates.GetEnumerator();
        }

        public bool Remove(Candidate item)
        {
            return _candidates.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _candidates.GetEnumerator();
        }
    }
}
