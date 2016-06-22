namespace _02_ProblemTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BasicStackOpereations
    {
        static void Main()
        {
            // Task: Play around with a stack. You will be given an integer N representing the amount of elements 
            // to push onto the stack, an integer S representing the amount of elements to pop from the stack 
            // and finally an integer X, an element that you should check whether is present in the stack. 
            // If it is print true on the console, if it’s not print the smallest element currently present in the stack.
            // Input Format: On the first line you will be given N, S and X separated by a single space. 
            // On the next line you will be given N amount of integers.
            // Output Format: On a single line print either true if X is present in the stack 
            // otherwise print smallest element in the stack. If the stack is empty print 0.

            // Input : 5 2 13          Output: true
            //         1 13 45 32 4

            string[] commands = Console.ReadLine().Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] numbersToPush =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Stack<int> myStack = new Stack<int>();

            int numbersToPop = int.Parse(commands[1]);
            int elementToCheck = int.Parse(commands[2]);

            for (int i = 0; i < numbersToPush.Length; i++)
            {
                myStack.Push(numbersToPush[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                myStack.Pop();
            }

            if (myStack.Count.Equals(0))
            {
                Console.WriteLine(0);
            }
            else if (!myStack.Contains(elementToCheck))
            {
                Console.WriteLine(myStack.Min());
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}