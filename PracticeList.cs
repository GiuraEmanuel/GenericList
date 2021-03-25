using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
                elements[Count] = item;
            }
            Count++;
        }


        public void Remove(T item)
        {
            T itemToRemove = item;
            int itemIndex = Array.IndexOf(elements, itemToRemove);
            elements = elements.Where((val, index) => index != itemIndex).ToArray();
            Count--;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                //if (EqualityComparer<T>.Default.Equals(item))
                //{
                //    return true;
                //}
                if (elements.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
