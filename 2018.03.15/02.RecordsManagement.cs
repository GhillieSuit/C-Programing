using System;

namespace Management_of_Records
{
    class RecordsManagement
    {
        static void Main(string[] args)
        {
            string[] name = new string[2];
            string[] number = new string[2];
            int[] mid = new int[2];
            int[] fin = new int[2];

            name[0] = "User1";
            number[0] = "201544058";
            mid[0] = 50;
            fin[0] = 70;

            name[1] = "User2";
            number[1] = "201544051";
            mid[1] = 40;
            fin[1] = 50;

            for (int i = 0; i < 2; i++)
            {
                int avg = (mid[i] + fin[i]) / 2;
                Console.WriteLine("{0}({1}): {2}/{3}/{4}", name[i], number[i], mid[i], fin[i], avg);
            }
        }
    }
}
