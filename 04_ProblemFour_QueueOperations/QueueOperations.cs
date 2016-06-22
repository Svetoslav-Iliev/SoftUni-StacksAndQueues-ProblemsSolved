namespace _04_ProblemFour_QueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class QueueOperations
    {
        static void Main()
        {
            // Play around with a queue. You will be given an integer N representing the amount of elements to enqueue,
            // an integer S representing the amount of elements to dequeue from the queue and finally an integer X, 
            // an element that you should check whether is present in the queue. If it is print true on the console, 
            // if it’s not print the smallest element currently present in the queue.
            int[] commands =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int numbersToQueue = commands[0];
            int numberToDequeue = commands[1];
            int numberToCheck = commands[2];

            int[] numbers =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            Queue<int> myQueue = new Queue<int>();

            for (int i = 0; i < numbersToQueue; i++)
            {
                myQueue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numberToDequeue; i++)
            {
                myQueue.Dequeue();
            }

            if (myQueue.Count.Equals(0))
            {
                Console.WriteLine(0);
            }
            else if (!myQueue.Contains(numberToCheck))
            {
                Console.WriteLine(myQueue.Min());
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}