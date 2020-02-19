using System;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        private const string V = "^[a-zA-Z]+$";

        static void Main(string[] args)
        {
            String name;
            String country;
            do{
                Console.WriteLine("Please Enter your Name: ");
                name = Console.ReadLine();
            }while(!Regex.IsMatch(name,"^[a-zA-Z]+$"));

            do{
                Console.WriteLine("Please Enter country: ");
                country = Console.ReadLine();
            }while(!Regex.IsMatch(country,"^[a-zA-Z]+$"));
            
            
            Console.WriteLine("Hi, " + name + " ,from " + country);
            Console.ReadLine();
        }
    }
}
