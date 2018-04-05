using System;
using System.Threading;

namespace MovingPoint
{
    class Point
    {
        public int X;
        public int Y;

        public static int maxX = 15;
        public static int maxY = 5;
        public static int Count = 0;

        public string Name;

        public static void AddCount()
        {
            Point.Count++;
        }

        public void MoveX(int step)
        {
            //this.X = (this.X + step) % Point.maxX;
            X = (X + step) % maxX;
        }

        public void MoveY(int step)
        {
            Y = (Y + step) % maxY;
        }
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

                Console.Write((i + 1) + "번째 점 : ");
                p.Name = Console.ReadLine();     //Read();

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
                    Console.Write(points[i].Name);

                    points[i].MoveX(1);
                    points[i].MoveY(1);

                }
                Console.SetCursorPosition(0, 10);
                Point.AddCount();
                Console.WriteLine("Count : " + Point.Count);
                Thread.Sleep(500);
            }
        }
    }
}