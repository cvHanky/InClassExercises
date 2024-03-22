using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public interface ILinkedList<T>
    {
        public int Count { get; }
        public T First { get; }
        public T Last { get; }
        public void InsertAt(int index, T item);
        public void Insert(T item);
        public void Append(T item);
        public void DeleteAt(int index);
        public T ItemAt(int index);
        public void Swap(int index);
    }
}
