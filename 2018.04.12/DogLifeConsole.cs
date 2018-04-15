using System;

namespace DogLifeConsole
{
    class Dog
    {
        public string Name;
        public int Level = 1;

        public static int maxLevel = 10;

        public void AddLevel()
        {
            if (this.Level >= maxLevel)
            {
                return;
            }
            else if (maxLevel < (this.Level + 1))
            {
                this.Level = maxLevel;
            }
            else
            {
                this.Level++;
            }
        }

        public void Info()
        {
            Console.WriteLine("현재 " + Name + "의 레벨은 " + Level + "입니다.");
        }
    }
    class DogLifeConsole
    {
        static void Main(string[] args)
        {
            Dog[] dogHouse;

            do
            {
                Console.Write("몇 마리의 개를 키우겠습니까(1~5)? : ");
                int count = int.Parse(Console.ReadLine());

                if (count > 0 && count < 6)
                {
                    dogHouse = new Dog[count];
                    break;
                }
            } while (true); 

            for (int i = 0; i < dogHouse.Length; i++)
            {
                Dog d = new Dog();

                Console.Write((i + 1) + "번째 강아지의 이름은? : ");
                d.Name = Console.ReadLine();

                dogHouse[i] = d;
            }

            while (true)
            {
                Console.WriteLine("\n아래와 같은 메뉴대로 실행하세요.");
                Console.WriteLine("1:먹이주기");
                Console.WriteLine("2:전체 멍멍이 상황 보기");
                Console.WriteLine("===================");
                string input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1:
                        Console.Write("강아지 이름 : ");
                        string temp = Console.ReadLine();

                        for (int i = 0; i < dogHouse.Length; i++)
                        {
                            if (dogHouse[i].Name == temp)
                            {
                                Console.Write(dogHouse[i].Name + "에게 먹이를 주고 싶으시면 Y, 그렇지 않으면 아무키를 누르세요 : ");
                                string tmp = Console.ReadLine();
                                if (tmp == "Y")
                                {
                                    dogHouse[i].AddLevel();
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if(dogHouse.Length == i + 1)
                                {
                                    Console.WriteLine("강아지의 이름을 찾을 수 없습니다.");
                                    Console.Write("강아지를 계속 찾으려면 C를, 그렇지 않으면 아무키를 누르세요 : ");
                                    string retry = Console.ReadLine();

                                    if(retry == "C")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < dogHouse.Length; i++)
                        {
                            dogHouse[i].Info();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}