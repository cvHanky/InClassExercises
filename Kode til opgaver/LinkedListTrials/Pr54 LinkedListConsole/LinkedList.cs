using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr54_LinkedListConsole
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set; }

        public void InsertAt(int index, object o)
        {
            if (Head == null && index == 0)  // Hvis listen er tom
            {
                Head = new Node();
                Head.Data = o;
            }

            else if (Head != null && index == 0) // Hvis man indsætter først i listen. 
            {
                Node temp = Head;    // Gemmer nuværende head

                Head = new Node();   // Laver nyt head. 
                Head.Data = o;

                Head.Next = temp;    // Referer nye head til gamle head. 
            }

            else if (Head != null && index != 0)  // Tilføjede et sted midt i listen (eller til slut)
            {
                Node current = Head;        // Først starter vi på node nummer 1 (som er indeks 0). 
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

            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            Count++;
        }

        public void DeleteAt(int index)
        {
            if (Head != null && index == 0)
            {
                Head = Head.Next;
            }

            if (Head != null && index != 0)                          // Hvis listen eksisterer
            {
                Node current = Head;                   // Vi starter på node 0. 

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                current.Next = current.Next.Next;      // Rykker pointeren til noden efter den næste node. ??
            }

            if (index > Count || index < 0) // hvis indeks ude af range
            {
                throw new IndexOutOfRangeException();
            }
            Count--;
        }

        public object? ItemAt(int index)
        {
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException();        // fsdfdsds out ofa nrange
            }

            if (Head != null && index == 0)
            {
                return Head.Data;
            }

            else if (Head != null && index != 0)
            {
                Node current = Head;

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

            if (Head != null)
            {
                Node current = Head;

                for (int i = 1; i < Count; ++i)
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
