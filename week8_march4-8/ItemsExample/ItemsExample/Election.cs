using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsExample
{
    public class Election : ICollection<string>
    {
        private List<Candidate> _candidates = new();
        private List<string> _allVotes = new();

        public Election(string[] names)
        {
            foreach (string n in names)
            {
                _candidates.Add(new Candidate(n));
            }
        }

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

        public void Vote(string n)
        {
            foreach (Candidate c in _candidates)
            {
                if (c.Name == n) c.Votes++;
            }
        }

        public int Count => _allVotes.Count;

        public bool IsReadOnly => false;

        public void Add(string item)
        {
            _allVotes.Add(item);
        }

        public void Clear()
        {
            _allVotes.Clear();
        }

        public bool Contains(string item)
        {
            return _allVotes.Contains(item);
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            _allVotes.CopyTo(array, arrayIndex);
        }

        public IEnumerator<string> GetEnumerator()
        {
            return _allVotes.GetEnumerator();
        }

        public bool Remove(string item)
        {
            return _allVotes.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _allVotes.GetEnumerator();
        }
    }
}
