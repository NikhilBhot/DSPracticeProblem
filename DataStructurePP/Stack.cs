using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePP
{
    public class Stack<T>
    {
        private T[] elements;
        private int top;

        public int Count { get; private set; }

        public Stack(int capacity)
        {
            elements = new T[capacity];
            top = -1;
            Count = 0;
        }

        public void Push(T item)
        {
            if (top == elements.Length - 1)
                throw new StackOverflowException("Stack is full");

            elements[++top] = item;
            Count++;
        }

        public T Pop()
        {
            if (top == -1)
                throw new InvalidOperationException("Stack is empty");

            T item = elements[top--];
            Count--;
            return item;
        }

        public T Peek()
        {
            if (top == -1)
                throw new InvalidOperationException("Stack is empty");

            return elements[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Clear()
        {
            top = -1;
            Count = 0;
        }
    }

}
