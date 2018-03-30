using System;
using System.Threading;

namespace MovingPoint
{
    class Point
    {
        public int X;
        public int Y;
    }

    class MovingPoint
    {
        static void Main(string[] args)
        {
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
        }
    }
}
