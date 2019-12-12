using System;
using System.Collections.Generic;

namespace data_structure
{
    internal class A003 : IRun
    {
        private Node003 _head;

        private void Add(Int32 data)
        {
            var newNode = new Node003
            {
                Data = data
            };

            if (_head == null)
            {
                _head = newNode;
                return;
            }
            var innerHead = _head;

            while (innerHead.Next != null)
            {
                innerHead = innerHead.Next;
            }
            innerHead.Next = newNode;
        }


        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Add(i);
            }


            Stack<Node003> stack = new Stack<Node003>();
            var innerHead = _head;
            while (innerHead != null)
            {
                stack.Push(innerHead);
                innerHead = innerHead.Next;
            }

            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop().Data);
            }
        }
    }

    internal class Node003
    {
        internal Int32 Data { get; set; }

        internal Node003 Next { get; set; }
    }
}