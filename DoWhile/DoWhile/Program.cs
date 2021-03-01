using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("i value: {0}", i);
                i++;
                if (i == 2)
                    break;
            } while (i < 4);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}