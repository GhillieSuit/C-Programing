using System;
using System.Threading;

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

            for (int i = 0; i < 50; i++)
            {
                Console.Clear();
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

                bool[,] tempGrid = new bool[10, 20];

                for (int y = 0; y < grid.GetLength(0); y++)
                {
                    for (int x = 0; x < grid.GetLength(1); x++)
                    {
                        if (grid[y, x])
                        {
                            //tempGrid[y, ((x + 1) % 15)] = true;                   //가로이동
                            //tempGrid[(y + 1) % 5, x] = true;                      //세로이동
                            tempGrid[(y + 1) % 5, ((x + 1) % 15)] = true;         //대각선이동
                        }
                    }
                }

                grid = tempGrid;

                Thread.Sleep(500);
            }
        }
    }
}
