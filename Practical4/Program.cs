using System;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            String infix = "a*(b+c)";
            String postfix;
            Console.WriteLine("Please Enter infix String: ");
            infix = Console.ReadLine();
            
            myClass.infixtopostfix(ref infix,out postfix);
            Console.WriteLine("Infix String : " + infix);
            Console.WriteLine("Postfix String : " + postfix);
            Console.ReadLine();   
        }
       
    }
}
