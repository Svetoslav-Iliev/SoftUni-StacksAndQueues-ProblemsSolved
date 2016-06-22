namespace WordCount
{
    using System;
    using System.Collections.Generic;

    class WordCount
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurances = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (!occurances.ContainsKey(currentSymbol))
                {
                    occurances[currentSymbol] = 0;
                }

                occurances[currentSymbol]++;
            }

            foreach (var kvp in occurances)
            {
                Console.WriteLine("{0} -> {1} times", kvp.Key, kvp.Value);
            }
        }
    }
}