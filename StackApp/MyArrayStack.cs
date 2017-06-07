using System;
using System.Collections;
using System.Collections.Generic;

namespace StackApp
{
    public class MyArrayStack<T> : IEnumerable<T>
    {
        T[] _list = new T[0];

        int _size = 0;

        public void Push(T item)
        {
            if (_size == _list.Length)
            {
                var newArrayLength = _size == 0 ? 4 : _size*2;
                T[] newArray = new T[newArrayLength];

                _list.CopyTo(newArray, 0);

                _list = newArray;
            }

            _list[_size++] = item;
        }

        public T Pop()
        {
            if (_size == 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }

            _size--;
            return _list[_size];
        }

        public T Peek()
        {
            if (_size == 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }

            return _list[_size - 1];
        }

        public int Count
        {
            get { return _size; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>) _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
