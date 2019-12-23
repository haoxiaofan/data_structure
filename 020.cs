using System;
using System.Collections.Generic;

namespace data_structure
{
    internal class A020 : IRun
    {

        private Stack<Int32> _s1 = new Stack<Int32>();

        private Stack<Int32> _s2 = new Stack<Int32>();

        internal Int32 Pop()
        {
            if (_s2.Count != 0)
            {
                return _s2.Pop();
            }

            return _s1.Pop();
        }

        internal void Push(Int32 data)
        {
            _s1.Push(data);

            if (_s2.Count == 0 || _s2.Peek() > data)
            {
                _s2.Push(data);
            }
            else
            {
                _s2.Push(_s2.Peek());
            }

        }

        public void Run()
        {
             Push(1);
             Push(2);
             Push(0);
             Push(3);
             Push(4);
             Push(4);
             Push(5);

            Console.WriteLine(Pop());
        }
    }
}