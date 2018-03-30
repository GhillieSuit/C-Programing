using System;

namespace TradingGame
{
    class TradingGame
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                a += rand.Next(4);
                b += rand.Next(4);
                c += rand.Next(4);
            }

            Console.Write("[A]");
            for (int i = 0; i < a; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();

            Console.Write("[B]");
            for (int i = 0; i < b; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();

            Console.Write("[C]");
            for (int i = 0; i < c; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
    }
}
