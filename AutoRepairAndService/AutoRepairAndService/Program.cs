using System;
using System.Collections.Generic;

namespace AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carsIn = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> queue = new Queue<string>(carsIn);
            Stack<string> servedVenicles = new Stack<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandCar = command.Split('-');
                if (commandCar[0] == "Service")
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine($"Vehicle {queue.Peek()} got served.");
                        servedVenicles.Push(queue.Dequeue());
                    }
                }
                if (commandCar[0] == "CarInfo")
                {
                    if (queue.Contains(commandCar[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                if (commandCar[0] == "History")
                {
                    Console.WriteLine(string.Join(", ", servedVenicles.ToArray()));
                }
            }
            if (queue.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queue.ToArray())}");
            }
            Console.WriteLine($"Served vehicles: {string.Join(", ", servedVenicles.ToArray())}");
        }
    }
}
