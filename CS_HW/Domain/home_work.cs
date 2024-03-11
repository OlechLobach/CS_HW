    using System;

    namespace Domain
    {
        public class Drawing
        {
            public void DrawSquare(int sideLength, char symbol)
            {
                for (int i = 0; i < sideLength; i++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < sideLength - 2; i++)
                {
                    Console.Write(symbol + " ");
                    for (int j = 0; j < sideLength - 2; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.WriteLine(symbol);
                }

                for (int i = 0; i < sideLength; i++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
    }