using System;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };

            int[] result = Domain.Filter.FilterArray(originalArray, filterArray);

            Console.WriteLine("Filtered Array:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}