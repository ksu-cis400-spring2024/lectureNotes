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
    public class Election : ICollection<Candidate>, INotifyCollectionChanged
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

        public bool IsReadOnly => false;

        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public void Add(Candidate item)
        {
            _candidates.Add(item);

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
