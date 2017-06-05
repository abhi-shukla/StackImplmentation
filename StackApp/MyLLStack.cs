using System;
using System.Collections;
using System.Collections.Generic;

namespace StackApp
{
    public class MyLLStack<T> : IEnumerable<T>
    {
        LinkedList<T> MyStack = new LinkedList<T>();

        public int Count
        {
            get 
            {
                return MyStack.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Push(T item)
        {
            MyStack.AddFirst(item);
        }

        public T Pop()
        {
            if(MyStack.Count == 0)
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }
            var item = MyStack.First.Value;
            MyStack.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (MyStack.Count == 0)
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }

            return MyStack.First.Value;
        }

        public void Add(T item)
        {
            Push(item);
        }

        public void Clear()
        {
            MyStack.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return MyStack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return MyStack.GetEnumerator();
        }
    }
}
