using System;

namespace Management_of_Records
{
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

    class RecordsManagement
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.name = "User";
            stu.number = "201544058";
            stu.mid = 50;
            stu.fin = 70;

            Console.WriteLine("{0}({1}): {2}/{3}/{4}", stu.name, stu.number, stu.mid, stu.fin, stu.Average());
        }
    }
}
