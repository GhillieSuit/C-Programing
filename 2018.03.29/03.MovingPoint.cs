using System;

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

            Console.Clear();

            int originX = Console.CursorLeft;
            int originY = Console.CursorTop;

            for (int i = 0; i < points.Length; i++)
            {
                Console.SetCursorPosition(originX + points[i].X, originY + points[i].Y);
                Console.Write("●");
            }

            Console.SetCursorPosition(0, 10);        
        }
    }
}
