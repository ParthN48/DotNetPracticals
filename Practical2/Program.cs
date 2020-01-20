using System;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            String country;
            Console.WriteLine("Please Enter your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your Country: ");
            country = Console.ReadLine();
            Console.WriteLine("Hi, " + name + " You are from " + country);
            Console.ReadLine();
        }
    }
}
