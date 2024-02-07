using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class AnimalCollection : ICollection<IAnimal>
    {
        private List<IAnimal> _list = new();

        public int Count => _list.Count;

        public bool IsReadOnly => ((ICollection<IAnimal>)_list).IsReadOnly;

        public void Add(IAnimal item)
        {
            ((ICollection<IAnimal>)_list).Add(item);
        }

        public void Clear()
        {
            ((ICollection<IAnimal>)_list).Clear();
        }

        public bool Contains(IAnimal item)
        {
            return ((ICollection<IAnimal>)_list).Contains(item);
        }

        public void CopyTo(IAnimal[] array, int arrayIndex)
        {
            ((ICollection<IAnimal>)_list).CopyTo(array, arrayIndex);
        }

        public IEnumerator<IAnimal> GetEnumerator()
        {
            return ((IEnumerable<IAnimal>)_list).GetEnumerator();
        }

        public bool Remove(IAnimal item)
        {
            return ((ICollection<IAnimal>)_list).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
