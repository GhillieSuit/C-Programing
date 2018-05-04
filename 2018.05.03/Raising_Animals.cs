using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDerived   //base-기본/부모   derived-파생/자식
{
    class Animal
    {
        protected string Name;
        protected int Weight;

        public Animal(string Name, int Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
        }
        public void Eat(int feed)
        {
            this.Weight += (feed / 2);
        }
        public void Info()
        {
            Console.WriteLine("{0}의 무게는 {1}입니다.\n", this.Name, this.Weight);
        }
    }

    class Dog : Animal
    {
        public Dog(string Name, int Weight) : base(Name, Weight)
        {

        }

        public void Bark()
        {
            Console.WriteLine(this.Name + " : bark bark");
        }
    }
    class Cat : Animal
    {
        public Cat(string Name, int Weight) : base(Name, Weight)
        {

        }

        public void Meow()
        {
            Console.WriteLine(this.Name + " : miaow~");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Max", 1);
            Cat cat = new Cat("Allie", 2);

            dog.Info();
            cat.Info();

            dog.Eat(10);
            cat.Eat(6);

            dog.Info();
            cat.Info();

            dog.Bark();
            cat.Meow();
        }
    }
}