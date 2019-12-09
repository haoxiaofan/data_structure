using System;

namespace data_structure
{
    internal class seq_list : IBase
    {
        private readonly Int32[] _array = new Int32[10];



        internal void Insert(Int32 index, Int32 data)
        {
            for (int i = _array.Length; i >= index; i--)
            {
                _array[i] = _array[i - 1];
            }
        }

        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                _array[i] = i;
            }
            Insert(2, 6);
        }
    }
}