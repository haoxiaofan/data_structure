using System;
using System.Collections.Generic;

namespace data_structure
{
    internal class A044 : IRun
    {
        public void Run()
        {
            var str1 = " I    am a  student.     ";
            str1 = str1.TrimStart().TrimEnd();

            var a1 = str1.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var s1 = new Stack<String>();

            for (int i = 0; i < a1.Length; i++)
            {
                s1.Push(a1[i]);
            }

            while (s1.Count != 0)
            {
                Console.WriteLine(s1.Pop());
            }
        }
    }
}