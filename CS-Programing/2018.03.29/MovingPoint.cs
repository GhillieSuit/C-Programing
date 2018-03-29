#define fourth

using System;
using System.Threading;

namespace ConsoleApp3
{
#if third
    class Point
    {
        public int X;
        public int Y;
    }
#endif //third

#if fourth
    class Point
    {
        public int X;
        public int Y;
    }
#endif //fourth

    class MovingPoint
    {
        static void Main(string[] args)
        {
#if first
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
#endif //first

#if second
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
#endif //second

#if third
            Point[] points = new Point[5];
            Random rand = new Random();

            for (int i = 0; i < points.Length; i++)
            {
                Point p = new Point();
                p.X = rand.Next(15);
                p.Y = rand.Next(5);

                points[i] = p;
            }

            Console.Clear();

            int originX = Console.CursorLeft;
            int originY = Console.CursorTop;

            for (int i = 0; i < points.Length; i++)
            {
                Console.SetCursorPosition(originX + points[i].X, originY + points[i].Y);
                Console.Write("●");
            }

            Console.SetCursorPosition(0, 10);
#endif //third

#if fourth
            Point[] points = new Point[5];
            Random rand = new Random();

            for (int i = 0; i < points.Length; i++)
            {
                Point p = new Point();
                p.X = rand.Next(15);
                p.Y = rand.Next(5);

                points[i] = p;
            }

            for (int k = 0; k < 50; k++)
            {
                Console.Clear();

                int originX = Console.CursorLeft;
                int originY = Console.CursorTop;

                for (int i = 0; i < points.Length; i++)
                {
                    Console.SetCursorPosition(originX + points[i].X, originY + points[i].Y);
                    Console.Write("●");

                    points[i].X = (points[i].X + 1) % 15;
                    points[i].Y = (points[i].Y + 1) % 5;
                }
                Thread.Sleep(500);
            }

            Console.SetCursorPosition(0, 10);
#endif //fourth
        }
    }
}
