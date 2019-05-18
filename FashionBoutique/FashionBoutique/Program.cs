using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> box = new Stack<int>(clothers);
            int rackSize = int.Parse(Console.ReadLine());
            int racksUsed = 1;
            int sum = 0;
            while(box.Count != 0)
            {
                int clothes = box.Peek();
                if ((sum+clothes) > rackSize)
                {
                    sum = 0;
                    racksUsed++;
                    continue;
                }
                if (sum+clothes == rackSize)
                {
                    sum = 0;
                    box.Pop();
                    if (box.Count == 0)
                    {
                        break;
                    }
                    racksUsed++;
                    continue;
                }
                sum+=box.Pop();

                //5 4 8 6 3 8 7 7 9
                //16

            }
            Console.WriteLine(racksUsed);
        }
    }
}
