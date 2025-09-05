﻿namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"Hello {input}");
                    continue;
                }
                break;
            }
        }
    }
}
