using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20, y = 10;
            if (x >= 10)
            {
                Console.WriteLine("x is Greater than 10");
            }

            if (y >= 5)
            {
                Console.WriteLine("y is less than or equals to 5");
            }

            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}