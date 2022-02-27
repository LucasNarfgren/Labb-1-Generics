using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1_Generics
{
    class LådaCollection : ICollection<Låda>
    {
        private List<Låda> innerCollection;

        public LådaCollection() { innerCollection = new List<Låda>(); }

        public Låda this[int index]
        {
            get { return (Låda)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }
        public int Count { get { return innerCollection.Count; } }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(Låda item)
        {
            if (!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("En låda med dessa dimensioner har redan lagts till. \nHöjd: {0} Längd: {1} Bredd: {2}",
                    item.höjd.ToString(),item.längd.ToString(),item.bredd.ToString());
            }
        }

        public void Clear()
        {
            innerCollection.Clear();
        }

        public bool Contains(Låda item)
        {
            bool DoesExist = false;

            foreach (Låda l in innerCollection)
            {
                if (l.Equals(item))
                {
                    DoesExist = true;
                }
            }
            return DoesExist;

        }
        public bool Contains(Låda item, EqualityComparer<Låda> comparer)
        {
            bool DoesExist = false;

            foreach (Låda L in innerCollection)
            {
                if (comparer.Equals(L,item))
                {
                    DoesExist = true;
                }
            }

            return DoesExist;
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }

        public bool Remove(Låda item)
        {
            bool remove = false;

            for (int i = 0; i < innerCollection.Count; i++)
            {
                Låda CurrentLåda = (Låda)innerCollection[i];
                if (new LådaSameDimensions().Equals(CurrentLåda,item))
                {
                    innerCollection.RemoveAt(i);
                    remove = true;
                    break;
                }
            }
            return remove;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
    }
}
