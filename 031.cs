using System;
using System.Collections.Generic;

namespace data_structure
{
    internal class A031 : IRun
    {
        internal Node031 _head;

        internal void Add(Int32 data)
        {
            var newNode = new Node031
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
            var head1 = new A031();
            head1.Add(1);
            head1.Add(2);
            head1.Add(3);
            head1.Add(6);
            head1.Add(7);

            var head2 = new A031();
            head2.Add(4);
            head2.Add(5);
            head2.Add(6);
            head2.Add(7);

            //var r = Method1(head1._head, head2._head);
            var r = Method2(head1._head, head2._head);
        }

        internal Node031 Method2(Node031 head1, Node031 head2)
        {
            var headLength1 = GetLength(head1);
            var headLength2 = GetLength(head2);
            var diff = 0;
            Node031 longs = null, shorts = null;
            if (headLength1 > headLength2)
            {
                longs = head1;
                shorts = head2;
                diff = headLength1 - headLength2;
            }
            else
            {
                longs = head2;
                shorts = head1;
                diff = headLength2 - headLength1;
            }

            for (int i = 0; i < diff; i++)
            {
                longs = longs.Next;
            }

            while (shorts != null && longs != null && shorts.Data != longs.Data)
            {
                shorts = shorts.Next;
                longs = longs.Next;
            }

            return longs;
        }

        internal Node031 Method1(Node031 head1, Node031 head2)
        {
            var innerHead1 = head1;
            var innerHead2 = head2;

            var stack1 = new Stack<Node031>();
            var stack2 = new Stack<Node031>();

            while (innerHead1 != null)
            {
                stack1.Push(innerHead1);
                innerHead1 = innerHead1.Next;
            }

            while (innerHead2 != null)
            {
                stack2.Push(innerHead2);
                innerHead2 = innerHead2.Next;
            }

            Node031 n3 = null;
            while (stack1.Count > 0 && stack2.Count > 0)
            {
                var n1 = stack1.Pop();
                var n2 = stack2.Pop();

                if (n1.Data == n2.Data)
                {
                    n3 = n1;
                    break;
                }
            }

            return n3;
        }

        private Int32 GetLength(Node031 node)
        {
            var innerHead = node;
            var length = 0;
            while (innerHead != null)
            {
                length = length + 1;
                innerHead = innerHead.Next;
            }
            return length;
        }
    }

    internal class Node031
    {
        internal Int32 Data { get; set; }

        internal Node031 Next { get; set; }
    }

}