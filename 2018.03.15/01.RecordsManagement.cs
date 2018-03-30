using System;

namespace Management_of_Records
{
    class RecordsManagement
    {
        static void Main(string[] args)
        {
            string name;
            string number;
            int mid;
            int fin;

            name = "User";
            number = "201544058";
            mid = 50;
            fin = 60;

            int avg = (mid + fin) / 2;

            //Console.WriteLine(name + "(" + number+") "+ avg);
            Console.WriteLine("{0}({1}): {2}/{3}/{4}", name, number, mid, fin, avg);
        }
    }
}
