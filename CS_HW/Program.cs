using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100); // Генеруємо випадкове число в діапазоні від 1 до 100
            }

            Console.WriteLine("Random array:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.Write("Enter 'asc' for ascending sort or 'desc' for descending sort: ");
            string sortOrder = Console.ReadLine();

            bool ascending = sortOrder.ToLower() == "asc";

            SortingHelper.BubbleSort(array, ascending);

            Console.WriteLine("Sorted array:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}