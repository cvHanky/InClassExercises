using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    public class LinkedList : ILinkedList
    {
        #region Node class
        class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }

            //public Node(object data) { Data = data; }

            public override string ToString()
            {
                return Data.ToString();
            }
        }
        #endregion

        #region Fields and Properties
        private Node head;
        private int count;
        public int Count { get; }
        #endregion

        public void InsertAt(int index, object o)
        {
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
            }

            else if (head != null && index != 0)  // Tilføjede et sted midt i listen (eller til slut)
            {
                Node current = head;        // Først starter vi på node nummer 1 (som er indeks 0). 
                Node? temp = null;

                for (int i = 1; i < index; i++)  // Finder frem til den rigtige node vha. indekset.
                {
                    current = current.Next;
                }

                if (current.Next != null)         // Gemmer den næste node hvis den eksisterer. 
                {
                    temp = current;
                }

                current.Next = new Node();
                current.Next.Data = o;
                current.Next.Next = temp;         // Linker tilbage til den gamle node. 
            }

            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            count++;
        }

        public void DeleteAt(int index)
        {
            if (head != null && index == 0)
            {
                head = head.Next;
            }

            if (head != null && index != 0)                          // Hvis listen eksisterer
            {
                Node current = head;                   // Vi starter på node 0. 

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                current.Next = current.Next.Next;      // Rykker pointeren til noden efter den næste node. ??
            }

            if (index > count || index < 0) // hvis indeks ude af range
            {
                throw new IndexOutOfRangeException();
            }
            count--;
        }

        public object? ItemAt(int index)
        {
            if (index > count || index < 0)
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
                return null;
        }

        public override string ToString()
        {
            string toBeWritten = "";

            if (head != null)
            {
                Node current = head;

                for (int i = 1; i < count; ++i)
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
