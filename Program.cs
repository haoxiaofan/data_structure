using System;
using System.Collections.Generic;
using System.Linq;

namespace data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            // IRun basea = new A044();
            // basea.Run();
            //_2To10("1101");
            // _8To10("53");
            // _16To10();


            var r = 0 * Pow(2, 3) + 1 * Pow(2, 2) + 1 * Pow(2, 1) + 1 * Pow(2, 0);
            var r2 = 1 * Pow(2, 3) + 1 * Pow(2, 2) + 0 * Pow(2, 1) + 1 * Pow(2, 0);
            // _10To2(43);
            // _10To8(796);
            // _10To16(796);
            AA(7);

        }

        private static void AA(Int32 data)
        {
            var shang = data;
            var yu = new Stack<Int32>();
            while (shang != 0)
            {
                var shang1 = shang / 2;
                yu.Push(shang % 2);
                shang = shang1;
            }
        }

        private static void _10To8(Int32 data)
        {
            var shang = data;
            var yu = new Stack<Int32>();
            while (shang != 0)
            {
                var shang1 = shang / 8;
                yu.Push(shang % 8);
                shang = shang1;
            }
        }

        private static void _10To2(Int32 data)
        {
            var shang = data;
            var yu = new Stack<Int32>();
            while (shang != 0)
            {
                var shang1 = shang / 2;
                yu.Push(shang % 2);
                shang = shang1;
            }
        }

        #region （二、八、十六进制） → （十进制）



        /// <summary>
        /// 二进制转十进制
        /// </summary>
        private static void _2To10(String str)
        {
            var array = GetArray(str);
            var result = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] * Pow(2, i);
            }
        }

        /// <summary>
        /// 八进制转十进制 
        /// </summary>
        private static void _8To10(String str)
        {
            var array = GetArray(str);
            var result = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] * Pow(8, i);
            }
        }

        private static void _16To10()
        {
            var array = new Int32[2] { WordMapper("B"), 2 };
            var result = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i] * Pow(16, i);
            }
        }

        #endregion

        private static Int32 WordMapper(String str)
        {
            switch (str)
            {
                case "A": return 10;
                case "B": return 11;
                case "C": return 12;
                case "D": return 13;
                case "E": return 14;
                case "F": return 15;
                default: throw new Exception();
            }
        }

        private static Int32[] GetArray(String str)
        {
            return str.Select(s => Int32.Parse(s.ToString())).Reverse().ToArray();
        }

        private static long Pow(long x, long y)
        {
            int i = 1;
            long X = x;
            if (y == 0)
            {
                return 1;
            }
            while (i < y)
            {
                x = x * X;
                i++;
            }
            return x;
        }
    }
}
