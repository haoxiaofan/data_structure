using System;

namespace data_structure
{
    internal class Seq_Linked : IBase
    {
        private Node _head;

        internal void Delete(Int32 pos)
        {
            var innerHead1 = _head;
            var innerHead2 = new Node();
            var innerPos = 1;
            while (innerHead1.Next != null)
            {
                innerPos = innerPos + 1;
                innerHead2 = innerHead1;
                innerHead1 = innerHead1.Next;
                if (innerPos == pos)
                {
                    break;
                }
            }

            innerHead2.Next = innerHead1.Next;
        }

        internal void Insert(Int32 pos, Int32 data)
        {
            var innerPos = 1;
            var innerHead = _head;
            while (innerHead.Next != null)
            {
                innerHead = innerHead.Next;
                innerPos = innerPos + 1;
                if (pos == innerPos)
                {
                    break;
                }
            }
            var newNode = new Node
            {
                Data = data
            };
            if (innerHead.Next == null)
            {
                innerHead.Next = newNode;
            }
            else
            {
                var oldNode = innerHead.Next;
                innerHead.Next = newNode;
                newNode.Next = oldNode;
            }
        }

        internal void Add(Int32 data)
        {
            if (_head == null)
            {
                _head = new Node
                {
                    Data = data
                };
                return;
            }
            Node innerHead = _head;
            while (innerHead.Next != null)
            {
                innerHead = innerHead.Next;
            }
            innerHead.Next = new Node()
            {
                Data = data
            };
        }

        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                Add(i);
            }

            Insert(10, 10);

            Delete(2);
        }
    }

    internal class Node
    {
        internal Int32 Data { get; set; }

        internal Node Next { get; set; }
    }
}