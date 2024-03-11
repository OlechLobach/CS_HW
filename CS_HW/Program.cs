using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the start of the range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int end = int.Parse(Console.ReadLine());

            int result = Calculator.MultiplyNumbersInRange(start, end);

            Console.WriteLine($"The product of numbers from {start} to {end} is: {result}");
        }
    }
}