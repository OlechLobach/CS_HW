using System;
using Domain;

namespace MainProject
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(rows, columns);

            Console.WriteLine("Generated matrix:");
            matrix.DisplayMatrix();

            Console.WriteLine($"Maximum element in the matrix: {matrix.CalculateMax()}");
            Console.WriteLine($"Minimum element in the matrix: {matrix.CalculateMin()}");
        }
    }
}