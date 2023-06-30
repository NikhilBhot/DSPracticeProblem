using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePP
{
    //Create generic class custom Queue datastructure .
    public class Queue<T>
    {
        private T[] elements;
        private int front;
        private int rear;

        public int Count { get; private set; }

        public Queue(int capacity)
        {
            elements = new T[capacity];
            front = 0;
            rear = -1;
            Count = 0;
        }

        public void Enqueue(T item)
        {
            if (Count == elements.Length)
                throw new InvalidOperationException("Queue is full");

            rear = (rear + 1) % elements.Length;
            elements[rear] = item;
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty");

            T item = elements[front];
            front = (front + 1) % elements.Length;
            Count--;
            return item;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return elements[front];
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void Clear()
        {
            front = 0;
            rear = -1;
            Count = 0;
        }
    }

}
