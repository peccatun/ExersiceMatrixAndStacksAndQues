using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<char> queue = new Queue<char>();
            Stack<string> undo = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                int operation = int.Parse(command[0]);
                if (operation == 1)
                {
                    int count = 0;
                    foreach (var ch in command[1])
                    {
                        queue.Enqueue(ch);
                        count++;
                    }
                    undo.Push(count.ToString());
                }
                if (operation == 2)
                {
                    int delete = int.Parse(command[1]);
                    if (queue.Count >= delete)
                    {
                        StringBuilder text = new StringBuilder();
                        for (int z = 0; z < delete; z++)
                        {
                            text.Append(queue.Dequeue());
                        }
                        undo.Push(text.ToString());
                    }
                }
                if (operation == 3)
                {
                    int index = int.Parse(command[1]);
                    if (index -1 >=0 && index <=queue.Count)
                    {
                        Console.WriteLine(queue.ElementAt(index-1));
                    }
                }
                if (operation == 4)
                {
                    if (undo.Count > 0)
                    {
                        bool isDigit = int.TryParse(undo.Peek(),out int ignoreMe);
                        if (isDigit)
                        {
                            int reverce = int.Parse(undo.Pop());
                            for (int j = 0; j < reverce; j++)
                            {
                                queue.Dequeue();
                            }
                        }
                        else
                        {
                            string input = undo.Pop();
                            foreach (var ch in input)
                            {
                                queue.Enqueue(ch);
                            }
                        }
                    }
                }
            }
        }
    }
}
