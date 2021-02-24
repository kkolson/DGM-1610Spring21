using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 4)
            {
                Console.WriteLine("i value: {0}", i);
                i++;
                if (i == 2)
                    break;
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}