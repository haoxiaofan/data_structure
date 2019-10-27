using System;
using System.Linq;

namespace data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 5, 8, 9, 6, 3, 5, 4, 7, 5, 2, 9, 1, 0, 5, 2, 6, 7, 4 };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }

            Console.WriteLine(String.Join(",", array.ToList()));
        }
    }
}
