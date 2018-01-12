using System;
using System.Collections.Generic;

namespace StacksChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Console.WriteLine("(){}(){}");
            if (Challenge("(){}(){}")) Console.WriteLine("True!\n");
            else Console.WriteLine("False!\n");

            Console.WriteLine("({(({}))})");
            if (Challenge("({(({}))})")) Console.WriteLine("True!\n");
            else Console.WriteLine("False!\n");

            Console.WriteLine("{{({)})}}");
            if (Challenge("{{({)})}}")) Console.WriteLine("True!\n");
            else Console.WriteLine("False!\n");

            Console.ReadLine();
        }

        public static bool Challenge(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if(stack.Count != 0 && stack.Peek() == '(')
                {
                    if (s[i] == ')') stack.Pop();
                    else stack.Push(s[i]);
                }
                else if (stack.Count != 0 && stack.Peek() == '{')
                {
                    if (s[i] == '}') stack.Pop();
                    else stack.Push(s[i]);
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            if (stack.Count == 0) return true;
            else return false;
        }
    }
}
