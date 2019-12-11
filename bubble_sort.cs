using System;

namespace data_structure
{
    internal class Bubble_Sort : IRun
    {
        public void Run()
        {
            var array = new Int32[5] { 2, 3, 4, 5, 1 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}