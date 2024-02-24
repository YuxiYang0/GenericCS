using System;
namespace Generic
{
    public class MyList<T>
    {
        private List<T> list = new List<T>();

        public void Add(T element)
        {
            list.Add(element);
        }

        public T Remove(int index)
        {
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        public bool Contains(T element)
        {
            return list.Contains(element);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            list.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            list.RemoveAt(index);
        }

        public T Find(int index)
        {
            return list[index];
        }
    }

}

