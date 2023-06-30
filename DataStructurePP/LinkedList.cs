using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePP
{
    //Create generic class custom Linkedlist datastructure .
    public class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public LinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public bool Remove(T data)
        {
            if (head == null)
                return false;

            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                        previous.Next = current.Next;

                    if (head == current)
                        head = current.Next;

                    if (tail == current)
                        tail = previous;

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Print()
        {
            Node<T> current = head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}
