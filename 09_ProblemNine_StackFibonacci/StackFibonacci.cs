namespace _09_ProblemNine_StackFibonacci
{
    using System;
    using System.Collections.Generic;

    class StackFibonacci
    {
        static void Main()
        {
            // There is another way of calculating the Fibonacci sequence using a stack. 
            // It is non recursive, so it does not make any unnecessary calculations. 
            // Try implementing it. First push 1 and 1 and them use popping peeking and pushing
            // to generate every consecutive number. 
            int number = int.Parse(Console.ReadLine());
            Stack<int> fibStack = new Stack<int>();
            fibStack.Push(1);
            fibStack.Push(1);
            int z = 1;
            for (int i = 0; i < number-2; i++)
            {
                int a = fibStack.Pop();
                int b = fibStack.Pop();
                z = a + b;

                fibStack.Push(b);
                fibStack.Push(a);
                fibStack.Push(z);
            }

            Console.WriteLine(z);

           

            
        }
    }
}
