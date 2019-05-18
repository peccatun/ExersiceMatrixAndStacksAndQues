using System;
using System.Collections.Generic;

namespace BalancedParemtheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();
            if (input == string.Empty)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < input.Length/2; i++)
            {
                stack.Push(input[i]);
            }
            int count = 0;
            for (int i = (input.Length/2); i < input.Length; i++)
            {
                if (stack.Count == 0)
                {
                    break;
                }
                if (stack.Peek() == '(' && stack.Count > 0)
                {
                    if (input[i] == ')')
                    {
                        stack.Pop();
                        count++;
                    }
                }
                if (stack.Count == 0)
                {
                    break;
                }
                if (stack.Peek() == '[')
                {
                    if (input[i] == ']')
                    {
                        stack.Pop();
                        count++;
                    }
                }
                if (stack.Count == 0)
                {
                    break;
                }
                if (stack.Peek() == '{' && stack.Count > 0)
                {
                    if (input[i] == '}')
                    {
                        stack.Pop();
                        count++;
                    }
                }
            }
            double chek = input.Length;
            if (stack.Count == 0 && count == chek/2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
