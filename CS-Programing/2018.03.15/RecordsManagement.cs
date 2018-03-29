#define third

using System;

namespace ConsoleApp1
{
#if third
    class Student
    {
        public string name;
        public string number;
        public int mid;
        public int fin;

        public int Average()
        {
            return (this.mid + this.fin) / 2;
        }
    }
#endif //third
    class Program
    {
        static void Main(string[] args)
        {
#if first
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
#endif //first

#if second
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

            for(int i = 0; i < 2; i++)
            {
                int avg = (mid[i] + fin[i]) / 2;
                Console.WriteLine("{0}({1}): {2}/{3}/{4}", name[i], number[i], mid[i], fin[i], avg);
            }
#endif //second

#if third
            Student stu = new Student();
            stu.name = "User";
            stu.number = "201544058";
            stu.mid = 50;
            stu.fin = 70;
            
            Console.WriteLine("{0}({1}): {2}/{3}/{4}", stu.name, stu.number, stu.mid, stu.fin, stu.Average());
#endif //third
        }
    }
}
