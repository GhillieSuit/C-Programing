using System;

namespace TradingGame
{
    class Item
    {
        public int Level;

        public void AddLevel(int addValue)
        {
            if (this.Level >= 20)
            {
                return;
            }
            else if (20 < (this.Level + addValue))
            {
                this.Level = 20;
            }
            else
            {
                this.Level += addValue;
            }
        }
    }

    class TradingGame
    {
        static void Main(string[] args)
        {
            Item[] item = new Item[3];
            Random rand = new Random();

            for (int i = 0; i < item.Length; i++)
            {
                item[i] = new Item();
            }

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < item.Length; k++)
                {
                    item[k].AddLevel(rand.Next(4));
                }
            }

            for (int k = 0; k < item.Length; k++)
            {
                Console.Write("[{0}]", (char)(k + 'A'));
                for (int i = 0; i < item[k].Level; i++)
                {
                    Console.Write("■");
                }
                Console.WriteLine();
            }
        }
    }
}
