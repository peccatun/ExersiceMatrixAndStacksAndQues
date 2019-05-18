using System;
using System.Linq;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dim = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] arr = new int[dim[0], dim[1]];
            for (int col = 0; col < arr.GetLength(0); col++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int row = 0; row < arr.GetLength(1); row++)
                {
                    arr[col, row] = numbers[row];
                }
            }

            for (int col = 0; col < arr.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < arr.GetLength(0); row++)
                {
                    sum += arr[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
