using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public interface ILinkedList
    {
        public int Count { get; }
        public object First { get; }
        public object Last { get; }

        public void InsertAt(int index, object item);
        public void Insert(object item);
        public void Append(object item);
        public void DeleteAt(int index);
        public void Swap(int index);
        public object? ItemAt(int index);
    }
}
