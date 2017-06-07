using System;
using System.Collections;
using System.Collections.Generic;

namespace StackApp
{
    public class MyLLStack<T> : IEnumerable<T>
    {
        private readonly LinkedList<T> _myStack = new LinkedList<T>();

        public int Count => _myStack.Count;

        public bool IsReadOnly => false;

        public void Push(T item)
        {
            _myStack.AddFirst(item);
        }

        public T Pop()
        {
            if(_myStack.Count == 0)
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }
            var item = _myStack.First.Value;
            _myStack.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (_myStack.Count == 0)
            {
                throw new IndexOutOfRangeException("The stack is empty");
            }

            return _myStack.First.Value;
        }

        public void Add(T item)
        {
            Push(item);
        }

        public void Clear()
        {
            _myStack.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _myStack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _myStack.GetEnumerator();
        }
    }
}
