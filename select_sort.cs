using System;

namespace data_structure
{
    internal class Select_Sort : IRun
    {
        public void Run()
        {
            var array = new Int32[6] { 1, 2, 3, 4, 5, 0 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                //假定外层循环temp为最小值
                var min = i;
                var temp = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    //内层循环判断array[j]是否比外层循环中的temp还要小
                    if (array[j] > temp)
                    {
                        //判断为真则将最小值更新为array[j]的值
                        min = j;
                        temp = array[j];
                    }
                }
                if (min != i)
                {
                    int swap = array[min];
                    array[min] = array[i];
                    array[i] = swap;
                }
            }
        }
    }
}