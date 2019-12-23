using System;
using System.Collections.Generic;

namespace data_structure
{
    internal class A005 : IRun
    {
        public void Run()
        {
            var s1 = new Stack<Int32>();
            var s2 = new Stack<Int32>();


            for (int i = 0; i < 10; i++)
            {
                s1.Push(i);
            }

            while (s1.Count != 0)
            {
                s2.Push(s1.Pop());
            }

            while (s2.Count != 0)
            {
                Console.WriteLine(s2.Pop());
            }
        }
    }
}