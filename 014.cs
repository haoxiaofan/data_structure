using System;

namespace data_structure
{
    internal class A014 : IRun
    {

        private Node014 _head;

        internal void Add(Int32 data)
        {
            var newNode = new Node014
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
            for (int i = 1; i <= 6; i++)
            {
                Add(i);
            }


            Node014 ahead = _head;
            Node014 behind = null;
            Int32 k = 3;
            for (int i = 0; i < k - 1; i++)
            {
                ahead = ahead.Next;
            }

            behind = _head;

            while (ahead.Next != null)
            {
                ahead = ahead.Next;
                behind = behind.Next;
            }

            Console.WriteLine(behind.Data);
        }
    }

    internal class Node014
    {
        internal Int32 Data { get; set; }

        internal Node014 Next { get; set; }
    }
}