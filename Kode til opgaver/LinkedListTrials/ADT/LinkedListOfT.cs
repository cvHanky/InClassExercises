using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class LinkedList<T> : ILinkedList<T>
    {
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
                    current.Next.Prev = current;       // Rykker pointere for noden efter index til noden før index. (hvis den ikke er null)
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
    }
}
