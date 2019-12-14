using System;

namespace data_structure
{
    internal class A055 : IRun
    {
        private Node055 _head;
        internal Node055 Add(Node055 newNode)
        {
            if (_head == null)
            {
                _head = newNode;
                return newNode;
            }
            var innerHead = _head;
            while (innerHead.Next != null)
            {
                innerHead = innerHead.Next;
            }
            innerHead.Next = newNode;
            return newNode;
        }

        public void Run()
        {
            Add(new Node055 { Data = 1 });
            Add(new Node055 { Data = 2 });
            var r = Add(new Node055 { Data = 3 });
            Add(new Node055 { Data = 4 });
            Add(new Node055 { Data = 5 });
            Add(new Node055 { Data = 6, Next = r });

            var meetNode = MeetNode(_head);
            var slow = _head;
            while (slow != meetNode)
            {
                slow = slow.Next;
                meetNode = meetNode.Next;
            }
        }

        internal Node055 MeetNode(Node055 head)
        {
            Node055 point = head;//指针1
            Node055 point1 = head;//指针2
            while (point1 != null && point1.Next != null)
            {
                point = point.Next;
                point1 = point1.Next.Next;
                if (point1 == point)
                {
                    return point1;
                }
            }
            return null;
        }
    }

    internal class Node055
    {
        internal Int32 Data { get; set; }

        internal Node055 Next { get; set; }
    }
}