using System;
namespace data_structure
{
    internal class Binary_Tree : IBase
    {
        private Binary_Node _root;
        private Int32[] _array = new Int32[20] { 7, 9, 8, 6, 5, 4, 698, 46, 51, 34, 64, 96, 8, 49, 40, 681, 65, 49, 84, 50 };

        internal void Add(Int32 data)
        {
            var newNode = new Binary_Node
            {
                Data = data
            };
            if (_root == null)
            {
                _root = newNode;
                return;
            }
            var currentNode = _root;
            while (true)
            {
                if (data < currentNode.Data)
                {
                    if (currentNode.Left != null)
                    {
                        currentNode = currentNode.Left;
                    }
                    else
                    {
                        currentNode.Left = newNode;
                        break;
                    }
                }
                else
                {
                    if (currentNode.Right != null)
                    {
                        currentNode = currentNode.Right;
                    }
                    else
                    {
                        currentNode.Right = newNode;
                        break;
                    }
                }
            }
        }

        public void Run()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Add(_array[i]);
            }
        }
    }

    internal class Binary_Node
    {
        public Int32 Data { get; set; }

        public Binary_Node Left { get; set; }

        public Binary_Node Right { get; set; }
    }
}