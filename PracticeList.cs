using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
    public class PracticeList<T> : IEnumerable<T>
    {

        private T[] elements = new T[10];

        public int Count { get; private set; }


        public void Add(T item)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = item;
            }
        }

        public void Remove(T item)
        {

        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }
    }
}
