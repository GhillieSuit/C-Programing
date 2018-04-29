using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogLifeConsole
{

    class Dog
    {
        public static int MaxLevel=30;

        public string Name = "이름없음";
        public int Level = 1;

        public bool AddLevel()
        {
            if (this.Level < 10) {
                this.Level++;
                return true;
            } else {
                return false;
            }
        }

        public void Info()
        {
            Console.WriteLine("현재 " + this.Name + "의 레벨은 " + this.Level + "입니다.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Dog[] dogHouse;

            do {
                Console.Write("몇 마리의 개를 키우겠습니까(1~5)?:");
                int count = int.Parse(Console.ReadLine());
                if (count >= 1 && count <= 5) {
                    dogHouse = new Dog[count];
                    break;
                } else {
                    Console.WriteLine("[다시 시도]");
                }

            } while (true);


            for (int i=0; i < dogHouse.Length; i++) {
                dogHouse[i] = new Dog();
                Console.Write(i + 1 + "번째 강아지의 이름은?");
                dogHouse[i].Name = Console.ReadLine();
            }

            while (true) {
                Console.WriteLine("\n아래와 같은 메뉴대로 실행하세요.");
                Console.WriteLine("1:먹이주기");
                Console.WriteLine("2:전체 멍멍이 상황 보기");
                Console.WriteLine("===================");

                string input = Console.ReadLine();

                if (input == "1") {
                    do {
                        Console.Write("강아지 이름: ");
                        string name = Console.ReadLine();
                        Dog searchDog = null;
                        for (int i=0; i < dogHouse.Length; i++) {
                            if (dogHouse[i].Name == name) {
                                searchDog = dogHouse[i];
                            }
                        }
                        if (searchDog == null) {
                            Console.WriteLine("강아지의 이름을 찾을 수 없습니다.");
                            Console.Write("강아지를 계속 찾으려면 C를, 그렇지 않으면 아무키를 누르세요:");
                            string check = Console.ReadLine();
                            if (check != "C")
                                break;
                        } else {
                            Console.WriteLine(searchDog.Name + "에게 먹이를 주고 싶으시면 Y, 그렇지 않으면 아무키를 누르세요:" );
                            string check = Console.ReadLine();

                            if (check == "Y") {
                                searchDog.AddLevel();
                                searchDog.Info();
                            }
                            break;
                        }
                    } while (true);

                } else if (input == "2") {
                    for (int i=0; i < dogHouse.Length; i++) {
                        dogHouse[i].Info();
                    }
                }
            }
        }
    }
}
