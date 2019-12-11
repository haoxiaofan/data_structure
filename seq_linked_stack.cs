using System;

namespace data_structure
{
    internal class Seq_Linked_Stack : IRun
    {

        private Linked_Stack_Node _head;

        internal void Push(Int32 data)
        {
            if (_head == null)
            {
                _head = new Linked_Stack_Node
                {
                    Data = data
                };
                return;
            }

            var newNode = new Linked_Stack_Node
            {
                Data = data
            };
            if (_head.Next == null)
            {
                _head.Next = newNode;
                return;
            }

            var oldNode = _head.Next;
            _head.Next = newNode;
            newNode.Next = oldNode;
        }

        internal Int32 Pop()
        {
            var innerHead = _head.Next;
            if (innerHead == null)
            {
                return -1;
            }
            _head.Next = innerHead.Next;
            return innerHead.Data;
        }

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Push(i);
            }

            while (true)
            {
                var r = Pop();

                if (r == -1)
                {
                    return;
                }
                Console.WriteLine(r);
            }
        }
    }

    internal class Linked_Stack_Node
    {
        internal Int32 Data { get; set; }

        internal Linked_Stack_Node Next { get; set; }
    }
}