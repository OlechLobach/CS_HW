using System;
using Domain; 
namespace SquareDrawingApp
{
    class Program
    {
        static void Main()
        {
            Drawing drawing = new Drawing();
            drawing.DrawSquare(5, '*');
        }
    }
}