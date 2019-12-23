using System;
using System.Collections.Generic;

namespace data_structure
{
    internal class A021 : IRun
    {
        public void Run()
        {
            var a1 = new Int32[5] { 1, 2, 3, 4, 5 };
            var a2 = new Int32[5] { 5, 4, 3, 2, 1 };

            var s1 = new Stack<Int32>();
            Int32 index = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                s1.Push(a1[i]);
                while (s1.Count != 0 && s1.Peek() == a2[index])
                {
                    s1.Pop();
                    index = index + 1;
                }
            }
            var r = s1.Count == 0;
        }
    }
}