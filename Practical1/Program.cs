using System;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern1();
            Console.WriteLine();
            Pattern2();
            Console.WriteLine();
            Pattern3();
            Console.Read();
            
        }
        static void Pattern1() 
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Pattern2() 
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = i; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Pattern3() 
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
