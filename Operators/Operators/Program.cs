using System;
using System.Collections.Generic;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;
            b = a + b * c;
            c = a >= 100 ? b : c / 10;
            a = (int) Math.Sqrt(b * b + c * c);

            string s = "String literal";
            char l = s[s.Length - 1];

            var numbers = new List<int>(new[] {1, 2, 3});
            b = numbers.FindLast(n => n > 1);
        }
    }
}