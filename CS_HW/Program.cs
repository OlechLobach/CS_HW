using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to check if it's a Fibonacci number and prime: ");
            int number = int.Parse(Console.ReadLine());

            if (MathHelper.IsFibonacci(number))
            {
                Console.WriteLine($"{number} is a Fibonacci number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Fibonacci number.");
            }

            if (MathHelper.IsPrime(number))
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }
    }
}