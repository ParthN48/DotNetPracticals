using System;
using System.Collections;
using System.Collections.Generic;

namespace Practical4
{
    class MyClass
    {
        public void infixtopostfix(ref String infix,out String postfix)
        {
            postfix = "";
            char ch;
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < infix.Length; i++)
            {
                ch = infix[i];
                if(isOperator(ch))
                {
                    if(stack.Count == 0)
                    {
                        stack.Push(ch);
                    }
                    else
                    {
                        if(ch == '(')
                        {
                            stack.Push(ch);
                        }
                        else if(ch == ')')
                        {
                            while(stack.Peek() != '(')
                            {
                                postfix += stack.Pop();
                            }
                            stack.Pop();
                        }
                        else
                        {
                            if(priority(ch) > priority(stack.Peek()))
                            {
                                stack.Push(ch);
                            }
                            else
                            {
                                postfix += stack.Pop();
                                i--;
                            }
                        }
                    }
                }
                else
                {
                    postfix += ch;
                }
            }
            foreach(var item in stack) {
                postfix += item;
            }
        }    
        public Boolean isOperator(char ch)
        {
            if(ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '%' || ch == '(' || ch == ')' )
            {
                return true;
            }
            else
                return false;
        }
        public int priority(char ch)
        {
            switch(ch)
            {
                case '(': return 0;
                case '+':
                case '-': return 1;
                case '*':
                case '/':
                case '%': return 2;
                default: return -1;
            }
        }
        
    }    
}
