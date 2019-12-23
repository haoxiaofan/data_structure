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
            node.Add(1);
            node.Add(2);
            node.Add(2);
            node.Add(3);
            node.Add(3);
            node.Add(4);
            node.Add(4);
            node.Add(5);

            var current = node._head;
            Node056 prev = null;

            while (current != null && current.Next != null)
            {
                if (current.Data != current.Next.Data)
                {
                     prev = current;
                    current = current.Next;
                    continue;
                }
                else
                {
                    while (current != null && current.Next != null && current.Data == current.Next.Data)
                    {
                        current = current.Next;
                    }

                    if (node._head.Data == current.Data)
                    {
                        node._head = current.Next;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }
                }
            }

            // var innerHead = node._head;
            // while (innerHead != null)
            // {
            //     if (innerHead.Next == null)
            //     {
            //         break;
            //     }
            //     if (innerHead.Data == innerHead.Next.Data)
            //     {
            //         innerHead.Next = innerHead.Next.Next;
            //     }
            //     else
            //     {
            //         innerHead = innerHead.Next;
            //     }
            // }

        }
    }

    internal class Node056
    {
        internal Int32 Data { get; set; }

        internal Node056 Next { get; set; }
    }
}