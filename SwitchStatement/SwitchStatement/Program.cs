using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            switch (x)
            {
                case 10:
                    Console.WriteLine("x value is 10");
                    break;
                case 15:
                    Console.WriteLine("x value is 15");
                    break;
                case 20:
                    Console.WriteLine("x value is 20");
                    break;
                default:
                    Console.WriteLine("Not Known");
                    break;
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}