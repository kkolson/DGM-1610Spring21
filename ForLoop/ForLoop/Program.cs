using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j < 3; j++)
                {
                    Console.WriteLine("i value: {0}, j value: {1}", i, j);
                }
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}