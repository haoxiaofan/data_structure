using System;

namespace data_structure
{
    internal class Seq_Stack : IRun
    {

        private Int32[] _array = new Int32[10];

        private Int32 _length = -1;

        internal void Push(Int32 data)
        {
            _array[++_length] = data;
        }

        internal Int32 Pop()
        {
            var data = _array[_length];
            --_length;
            return data;
        }

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Push(i);
            }

            for (; ; )
            {
                Pop();
            }

        }
    }
}