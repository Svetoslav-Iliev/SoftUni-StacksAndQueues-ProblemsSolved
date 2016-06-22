namespace _08_ProblemEight_RecursiveFibonacci
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    class RecursiveFibonacci
    {
        
        static void Main()
        {
            // The Fibonacci sequence is quite a famous sequence of numbers. Each member of the sequence 
            // is calculated from the sum of the two previous elements. The first two elements are 1, 1. 
            // Therefore the sequence goes as 1, 1, 2, 3, 5, 8, 13, 21, 34… 
            // The following sequence can be generated with an array, but that’s easy, 
            // so your task is to implement recursively.

            int fibonacciNumber = int.Parse(Console.ReadLine());

            Console.Write(GetFibonacci(fibonacciNumber));
            
            
        }

        public static int GetFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            while (n-- > 1)
            {
                int t = a;
                a = b;
                b += t;
            }
            return b;

        }
    }
}
