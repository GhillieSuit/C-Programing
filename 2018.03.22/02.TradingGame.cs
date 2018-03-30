using System;

namespace TradingGame
{
    class TradingGame
    {
        static void Main(string[] args)
        {
            int[] item = new int[3];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                //for (int k = 0; k < 3; i++){
                for (int k = 0; k < item.Length; k++)
                {
                    item[k] += rand.Next(4);
                }
            }

            for (int k = 0; k < item.Length; k++)
            {
                Console.Write("[{0}]", (char)(k + 'A'));
                for (int i = 0; i < item[k]; i++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
    }
}
