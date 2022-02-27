using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb_1_Generics
{
    class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection LådCollection;
        private int CurrentIndex;
        private Låda CurrentLåda;

        public LådaEnumerator(LådaCollection collection)
        {
            LådCollection = collection;
            CurrentIndex = -1;
            CurrentLåda = default(Låda);
        }

        public Låda Current { get { return CurrentLåda; } }

        object IEnumerator.Current => throw new NotImplementedException();



        public bool MoveNext()
        {
            if (++CurrentIndex >= LådCollection.Count)
            {
                return false;
            }
            else
            {
                CurrentLåda = LådCollection[CurrentIndex];
            }
            return true;
        }

        public void Reset()
        {
            CurrentIndex = -1;
        }

        public void Dispose()
        {
            
        }
    }
}
