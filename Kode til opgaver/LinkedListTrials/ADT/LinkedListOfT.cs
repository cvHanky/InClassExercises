using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class LinkedList<T> : ILinkedList<T>
    {
        #region Enumerator class
        class LinkedListEnumerator : IEnumerator<T>
        {
            private Node _head;
            private Node _current;
            private bool isReset;

            public T Current
            {
                get { return _current.Data; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public LinkedListEnumerator(Node head)
            {
                _head = head;
                isReset = true;
            }

            public bool MoveNext()
            {
                if (_current == null && isReset)
                {
                    _current = _head;
                    isReset = false;
                    if (_current == null)
                        return false;
                    else
                        return true;
                }
                if (_current != null)
                {
                    _current = _current.Next;
                    if (_current == null)
                        return false;
                    else
                        return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                _current = null;
                isReset = true;
            }

            public void Dispose()
            {

            }
        }
        #endregion

        #region Node class
        class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            //public Node(object data) { Data = data; }

            public override string ToString()
            {
                return Data.ToString();
            }
        }
        #endregion

        #region Fields and Properties
        private Node head;
        private int _count;
        public int Count
        {
            get { return _count; }
        }
        public T? First
        {
            get { return Count == 0 ? default(T) : ItemAt(0); }
        }
        public T? Last
        {
            get { return Count == 0 ? default(T) : ItemAt(Count - 1); }
        }
        #endregion

        public void InsertAt(int index, T o)
        {
            if (index > _count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (head == null && index == 0)  // Hvis listen er tom
            {
                head = new Node();
                head.Data = o;
            }

            else if (head != null && index == 0) // Hvis man indsætter først i listen. 
            {
                Node temp = head;    // Gemmer nuværende head

                head = new Node();   // Laver nyt head. 
                head.Data = o;

                head.Next = temp;    // Referer nye head til gamle head. 
                head.Next.Prev = head;  // Referer gamle head til nye head. 
            }

            else if (head != null && index != 0)  // Tilføjede et sted midt i listen (eller til slut)
            {
                Node current = head;        // Først starter vi på node nummer 1 (som er indeks 0). 
                Node? temp = null;

                for (int i = 1; i < index; i++)  // Finder frem til den rigtige node vha. indekset.
                {
                    current = current.Next;
                }

                if (current.Next is not null)         // Gemmer den næste node hvis den eksisterer. 
                {
                    temp = current.Next;
                }

                current.Next = new Node();
                current.Next.Data = o;
                current.Next.Next = temp;         // Linker tilbage til den gamle node. 
                current.Next.Prev = current;      // Linker den nye node til den node lige før den. 

                if (current.Next.Next is not null)
                    current.Next.Next.Prev = current.Next;      // Linker noden efter den nye node tilbage til den nye node. 
            }
            _count++;
        }

        public void Insert(T o)
        {
            InsertAt(0, o);
        }

        public void Append(T o)
        {
            InsertAt(Count, o);
        }

        public void DeleteAt(int index)
        {
            if (index > _count || index < 0) // hvis indeks ude af range
            {
                throw new IndexOutOfRangeException();
            }

            if (head != null && index == 0)
            {
                head.Next.Prev = null;
                head = head.Next;
            }

            else if (head != null && index != 0)       // Hvis listen eksisterer
            {
                Node current = head;                   // Vi starter på node 0. 

                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                if (current.Next.Next != null)
                    current.Next.Next.Prev = current;       // Rykker pointere for noden efter index til noden før index. (hvis den ikke er null)
                current.Next = current.Next.Next;      // Rykker pointeren til noden efter den næste node. 
            }
            _count--;
        }

        public T? ItemAt(int index)
        {
            if (index > _count || index < 0)
            {
                throw new IndexOutOfRangeException();        // fsdfdsds out ofa nrange
            }

            if (head != null && index == 0)
            {
                return head.Data;
            }

            else if (head != null && index != 0)
            {
                Node current = head;

                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Next.Data;
            }
            else
                return default(T);
        }

        public void Swap(int index)
        {
            if (index > _count || index < 0)
                return;

            if (ItemAt(index) == null || ItemAt(index + 1) == null)
                return;

            Node current = head;
            Node? temp = null;

            if (index != 0)
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                temp = current.Next;
                DeleteAt(index);
                InsertAt(index + 1, temp.Data);
            }

            else if (index == 0)
            {
                temp = current;
                DeleteAt(index);
                InsertAt(index + 1, temp.Data);
            }
        }

        public override string ToString()
        {
            string toBeWritten = "";

            if (head != null)
            {
                Node current = head;

                for (int i = 1; i < _count; ++i)
                {
                    toBeWritten += current.ToString();
                    toBeWritten += "\n";
                    current = current.Next;
                }
                toBeWritten += current.ToString();
            }
            return toBeWritten;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator(head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Sort()
        {
            if (head == null || Count < 1)
            {
                return;
            }

            // Vi starter ved head.
            if (head != null && Count > 1)
            {
                for (int k = 0; k < Count - 1; k++)              // We loop through the list as many times as there are items in the list.
                {                                                // A 5 long list will be looped through 5 times. 
                    Node current = head;
                    for (int i = 0; i < Count - 1; i++)
                    {
                        current = head;    // Have to navigate to correct node at the start of this loop as well. 
                        for (int g = 0; g < i; g++)
                        {
                            current = current.Next;
                        }

                        for (int j = i; j < Count - 1; j++)
                        {
                            IComparable<T> Ccurrent = current.Data as IComparable<T>;    // Casting the data to the IComparable interface
                            if (Ccurrent.CompareTo(current.Next.Data) > 0)               // so our CompareTo() method works. 
                            {
                                Swap(j);
                                                        // After the swap, current now points to old data. Gotta renew the pointer. 
                                current = head.Next;
                                if (j != 0)
                                {
                                    for (int l = 1; l < j + 1; l++)  // We start at the head. Then navigate to the spot after where we left off. 
                                    {
                                        current = current.Next;
                                    }
                                }
                            }
                            else      // If we don't swap, we simply leave the for loop. 
                                break;
                        }
                    }
                }
            }
        }
    }
}
