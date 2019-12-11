using System;

namespace data_structure
{
    internal class Insert_Sort : IRun
    {
        public void Run()
        {
            var array = new Int32[7] { 4, 5, 6, 3, 2, 0, 1 };
            Int32 i = 0, j = 0;
            //首先假定数组中第一个元素为已排序
            for (i = 1; i < array.Length; i++)
            {
                //保存当前元素，并在内层循环中判断数组中前一个元素是否大于当前元素
                var temp = array[i];
                for (j = i; j > 0 && array[j - 1] > temp; j--)
                {
                    //前后元素交换位置
                    array[j] = array[j - 1];
                }
                array[j] = temp;
            }
        }
    }
}