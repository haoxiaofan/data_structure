using System;

namespace data_structure
{
    internal class A016 : IRun
    {

        internal Node016 _head;

        internal void Add(Int32 data)
        {
            var newNode = new Node016
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
            var head1 = new A016();
            head1.Add(1);
            head1.Add(3);
            head1.Add(5);

            var head2 = new A016();
            head2.Add(2);
            head2.Add(4);
            head2.Add(6);

            var r = Merge(head1._head, head2._head);
        }

        private Node016 Merge(Node016 head1, Node016 head2)
        {

            if (head1 == null)
            {
                return head2;
            }
            else if (head2 == null)
            {
                return head1;
            }

            Node016 newNode = null;
            if (head1.Data >= head2.Data)
            {
                newNode = head2;
                newNode.Next = Merge(head1, head2.Next);
            }
            else
            {
                newNode = head1;
                newNode.Next = Merge(head1.Next, head2);
            }
            return newNode;
        }
    }

    internal class Node016
    {
        internal Int32 Data { get; set; }

        internal Node016 Next { get; set; }
    }
}