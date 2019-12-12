using System;
using System.Collections.Generic;

namespace data_structure
{
    internal class A015 : IRun
    {

        private Node015 _head;

        internal void Add(Int32 data)
        {
            var newNode = new Node015
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
            for (int i = 1; i <= 10; i++)
            {
                Add(i);
            }
            {
                // var nodes = new List<Node015>();
                // var innerNode = _head;
                // while (innerNode != null)
                // {
                //     nodes.Add(innerNode);
                //     innerNode = innerNode.Next;
                // }

                // for (int i = nodes.Count - 1; i >= 0; i--)
                // {
                //     if (i == 0)
                //     {
                //         nodes[i].Next = null;
                //         break;
                //     }

                //     nodes[i].Next = nodes[i - 1];
                // }
                // _head = nodes[nodes.Count - 1];
            }
            {
                if (_head == null)
                {
                    return;
                }

                Node015 reverseHead = null;
                Node015 currentNode = _head;
                Node015 prevNode = null;
                while (currentNode != null)
                {
                    var nextNode = currentNode.Next;
                    if (nextNode == null)
                    {
                        reverseHead = currentNode;
                    }
                    currentNode.Next = prevNode;
                    prevNode = currentNode;
                    currentNode = nextNode;
                }
            }
        }
    }

    internal class Node015
    {
        internal Int32 Data { get; set; }

        internal Node015 Next { get; set; }
    }
}