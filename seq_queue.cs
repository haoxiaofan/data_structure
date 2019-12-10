using System;

namespace data_structure
{
    internal class Seq_Queue : IBase
    {
        private const Int32 _maxLength = 10;

        private Int32[] _array = new Int32[_maxLength];

        private Int32 _count = 0, _front = 0, rear = 0;

        internal void Enqueue(Int32 data)
        {
            _array[rear] = data;
            _count = _count + 1;
            rear = (rear + 1) % _maxLength;
        }

        internal Int32 Dequeue()
        {
            var data = _array[_front];
            _front = (_front + 1) % _maxLength;
            _count = _count - 1;
            return data;
        }


        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Enqueue(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Dequeue());
            }
        }
    }
}