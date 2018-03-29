#define fifth
using System;

namespace ConsoleApp2
{
#if fourth
    class Item
    {
        public int Level;
    }
#endif //fourth

#if fifth
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
#endif //fifth

    class TradingGame
    {
        static void Main(string[] args)
        {
#if first
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
#endif //first

#if second
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
#endif //second

#if third
            int[] item = new int[3];
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < item.Length; k++)
                {
                    item[k] += rand.Next(4);

                    if (item[k] > 20)           //레벨의 최댓값을 20으로 제한
                    {
                        item[k] = 20;
                    }
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
#endif //third

#if fourth
            Item[] item = new Item[3];
            Random rand = new Random();

            for (int i = 0; i < item.Length; i++)
            {
                item[i] = new Item();
            }

            for (int i = 0; i < 10; i++)
            {
                //for (int k = 0; k < 3; i++){
                for (int k = 0; k < item.Length; k++)
                {
                    item[k].Level += rand.Next(4);
                    if (item[k].Level > 20)
                    {
                        item[k].Level = 20;
                    }
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
#endif //fourth

#if fifth
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
#endif //fifth
        }
    }
}
