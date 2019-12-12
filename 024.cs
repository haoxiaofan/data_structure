using System;

namespace data_structure
{
    internal class A024 : IRun
    {

        private Node024 _head;

        internal void Add(Int32 data)
        {
            var newNode = new Node024
            {
                Data = data
            };

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            var innerNode = _head;
            while (innerNode.Next != null)
            {
                innerNode = innerNode.Next;
            }
            innerNode.Next = newNode;
        }
        public void Run()
        {
            for (int i = 1; i <= 5; i++)
            {
                Add(i);
            }

            CloneNode(_head);
            Connection(_head);
        }

        internal void CloneNode(Node024 head)
        {
            var innerHead = head;
            while (innerHead != null)
            {
                var newNode = new Node024
                {
                    Data = innerHead.Data,
                    Next = innerHead.Next,
                    Sibling = null
                };
                innerHead.Next = newNode;
                innerHead = newNode.Next;
            }
        }

        internal void Connection(Node024 head)
        {
            var innerHead = head;
            while (innerHead != null)
            {
                var cloneNode = innerHead.Next;
                if (innerHead.Sibling != null)
                {
                    cloneNode.Sibling = innerHead.Sibling;
                }
                innerHead = cloneNode.Next;
            }
        }
    }

    internal class Node024
    {
        internal Int32 Data { get; set; }

        internal Node024 Next { get; set; }

        internal Node024 Sibling { get; set; }
    }
}