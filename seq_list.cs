using System;

namespace data_structure
{
    internal class Seq_List : IRun
    {
        private readonly Int32[] _array = new Int32[10];
 
        internal void Insert(Int32 index, Int32 data)
        {
            var i = 0;
            for (i = _array.Length - 1; i >= index; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[i] = data;
        }

        internal void Delete(Int32 index)
        {
            for (int i = index; i < _array.Length - 1; i++)
            {
                _array[i - 1] = _array[i];
            }
        }

        internal Int32 Get(Int32 index)
        {
            return _array[index];
        }

        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                _array[i] = i;
            }
            Insert(3, 6);

            Delete(3);
        }
    }
}