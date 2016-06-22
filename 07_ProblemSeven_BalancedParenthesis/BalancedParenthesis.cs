namespace _07_ProblemSeven_BalancedParenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    class BalancedParenthesis
    {
        static void Main()
        {
            // Given a sequence consisting of parentheses, determine whether the expression is balanced. 
            // A sequence of parentheses is balanced if every open parenthesis can be paired uniquely with a closed 
            // parenthesis that occurs after the former. Also, the interval between them must be balanced. 
            // You will be given three types of parentheses: (, {, and [.
            // Input Format: Each input consists of a single line, S, the sequence of parentheses.
            // Constraints: 
            // 1 ≤ lens ≤ 1000, where lens is the length of the sequence. 
            // Each character of the sequence will be one of {, }, (, ), [, ].
            // Output Format: For each test case, print on a new line "YES" if the parentheses are balanced. Otherwise, print "NO". Do not print the quotes

            string input = Console.ReadLine();
            if (input != null)
            {
                char[] charArray = input.ToCharArray();
                bool isBalanced = true;

                Stack<char> myStack = new Stack<char>();

                for (int i = 0; i < charArray.Length; i++)
                {
            
                    if (input[i] == '(' || input[i] == '{' || input[i] == '[')
                    {
                        myStack.Push(input[i]);
                    }
                    else if (myStack.Count == 0)
                    {
                        isBalanced=false;
                    }
                    else
                    {
                        myStack.Pop();
                    }   
                }

                if (isBalanced)
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
}