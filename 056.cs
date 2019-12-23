using System;

namespace data_structure
{
    internal class A056 : IRun
    {
        private Node056 _head;
 
        internal void Add(Int32 data)
        {
            var newNode = new Node056
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
            var node = new A056();
            node.Add(1);
            node.Add(2);
            node.Add(3);
            node.Add(4);
            node.Add(4);
            node.Add(5);
            node.Add(6);
            node.Add(6);

            
        }
    }

    internal class Node056
    {
        internal Int32 Data { get; set; }

        internal Node056 Next { get; set; }
    }
}