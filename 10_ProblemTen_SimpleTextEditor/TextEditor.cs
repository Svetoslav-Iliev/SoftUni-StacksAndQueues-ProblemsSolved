using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        Stack<string> text = new Stack<string>();

        int entries = int.Parse(Console.ReadLine());

        for (int i = 0; i < entries; i++)
        {
            string[] commands = Console.ReadLine().Trim().Split();
            string temp = "";
            switch (commands[0])
            {
                case "1":
                    temp = (text.Count == 0) ? "" : text.Peek();
                    temp += commands[1];
                    text.Push(temp);
                    break;
                case "2":
                    temp = text.Peek();
                    temp = temp.Remove(temp.Length - int.Parse(commands[1]));
                    text.Push(temp);
                    break;
                case "3":
                    temp = text.Peek();
                    Console.WriteLine(temp[int.Parse(commands[1]) - 1]);
                    break;

                case "4":
                    if (text.Count != 0)
                    {
                        text.Pop();
                    }

                    break;

                default:
                    break;
            }
        }
    }
}