using System;

namespace MovingPoint
{
    class MovingPoint
    {
        static void Main(string[] args)
        {
            bool[,] grid = new bool[5, 15];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int x = rand.Next(15);
                int y = rand.Next(5);

                if (grid[y, x])
                {
                    i--;
                }
                else
                {
                    grid[y, x] = true;
                }
            }

            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    if (grid[y, x])
                    {
                        Console.Write("●");
                    }
                    else
                    {
                        Console.Write("　");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
        }
    }
}
