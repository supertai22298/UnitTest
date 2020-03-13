using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    public class Stack : IStack
    {
        private int Top;
        private string[] _data = new string[100];
        public Stack()
        {
            Top = -1;
        }
        public bool IsEmpty()
        {
            return Top < 0;
        }

        public bool Push(string item)
        {
            if (Top >= 100) return false;
            _data[++Top] = item;
            return true;
        }

        public string Pop()
        {
            if (Top < 0) return null;
            string value = _data[Top];
            _data[Top] = null;
            Top--;
            return value;
        }

        public string Peek()
        {
            if (Top < 0) return null;
            return _data[Top];
        }

        public bool Clear()
        {
            _data = new string[100];
            Top = -1;
            return true;
        }

        public int Length()
        {
            return Top + 1;
        }
        public override string ToString()
        {
            if (_data.Length == 0) return null;
            string result = null;
            foreach (var item in _data)
            {
                result += item!= null ? $"{item}.": null;
            }

            return result;
        }
    }

    public interface IStack
    {
        public bool IsEmpty();
        public bool Push(string item);
        public string Pop();
        public string Peek();
        public bool Clear();
    }
}
