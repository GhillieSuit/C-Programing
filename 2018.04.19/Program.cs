using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameCardB
{
    class Program
    {
        static NameCard[] NameCardList;
        static int Count = 0;

        //CLR이 호출합니다.
        static void Main(string[] args)
        {
            Program.NameCardList = new NameCard[10];

            do
            {
                Console.WriteLine("===================================");
                Console.WriteLine("=  명 함 입 력 / 관 리 프 로 그 램  =");
                Console.WriteLine("===================================");

                Console.WriteLine("1. 명함 입력");
                Console.WriteLine("2. 명함 관리");
                Console.WriteLine("3. 종료");
                Console.WriteLine("-----------------------------------");
                string menu = Console.ReadLine();

                switch (menu.Trim())
                {
                    case "1":

                        if (Program.Count < Program.NameCardList.Length)
                        {
                            NameCard nameCard = Program.GetNewNameCard();
                            if (nameCard != null)
                            {
                                Program.NameCardList[Program.Count++] = nameCard;
                            }
                        }
                        else
                        {
                            Console.WriteLine("관리 가능한 명함을 추가할 수 없습니다.");
                        }
                        break;
                    case "2":
                        Program.ManageNameCard();
                        break;
                    case "3":
                        Console.WriteLine("프로그램을 종료합니다.");
                        return;
                    default:
                        break;
                }


            } while (true);
        }

        private static NameCard GetNewNameCard()
        {
            Console.WriteLine("+ 명 함 입 력 +");

            //아래 변수는 지역변수 - 사용자 입력 데이터를 잠깐 보관하기 위해...
            int group;   //0: 미분류 1:친구 2:회사 3: 가족
            string name;    //이름            
            string[] phone = new string[NameCard.MaxPhoneNumber]; //연락처
            string content; 

            string temp; //임시 변수

            Console.WriteLine();
            Console.WriteLine("그룹을 결정해주세요.(번호 입력)");
            for (int i = 0; i < NameCard.GroupName.Length; i++)
            {
                Console.WriteLine("{0}:{1}", i + 1, NameCard.GroupName[i]);
            }
            Console.Write(">> ");
            temp = Console.ReadLine();

            if(int.TryParse(temp, out group))//c언어의 포인터와 유사
            {
                if (group < 1 || group > NameCard.GroupName.Length)
                {
                    group = 0;
                }
                else
                {
                    group--;
                }
            }
            else
            {
                group = 0;
            }

            Console.WriteLine("이름을 넣어주세요.");
            Console.Write(">> ");
            name = Console.ReadLine();

            Console.WriteLine("전화번호 넣어주세요. (최대 5개 가능");
            for (int i = 0; i < phone.Length; i++)
            {
                Console.Write("{0}번 >> ",  i + 1); //순번은 1~부터 출력하도록
                temp = Console.ReadLine();

                if (string.IsNullOrEmpty(temp))
                { 
                    break;
                }
                else
                {
                    phone[i] = temp;
                }
            }

            Console.WriteLine("항목 외 정보를 넣어주세요.");
            Console.Write(">> ");
            content = Console.ReadLine();

            NameCard nc = new NameCard(group, name, phone, content);

            Console.WriteLine("[입력한 명함의 전체 정보]");
            nc.PrintNameCard();

            return nc;//만들어진 명함을 반환한다.

        }

        private static void ManageNameCard()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++");
            Console.WriteLine("+ 명 함 관 리 +");
            Console.WriteLine("++++++++++++++");

            if (Program.Count == 0)
            {
                Console.WriteLine("관리할 명함이 존재하지 않음");
                return;
            }


            do
            {
                string temp = string.Empty; //빈 문자열 넣는 것 보다, 이를 넣는게 권장사항?

                Console.WriteLine("명함목록");
                                
                //for문 이용해서 관리 가능한 명함의 순번과 이름을 출력한다.
                for (int i = 0; i < NameCardList.Length; i++)
                {
                    if (NameCardList[i] != null)
                    {
                        Console.WriteLine("{0} : {1}", i + 1, NameCardList[i].GetName());
                    }
                }

                Console.WriteLine("------------------------------------");
                Console.Write("관리하려는 명함 번호:(Q입력시 메인으로 이동) >>");


                temp = Console.ReadLine();
                if (temp.Trim().ToUpper() == "Q")
                {
                    break;
                }
                else
                {
                    int selectedIndex = 0; //사용자가 선택한 명함 순번
                    if (int.TryParse(temp.Trim(), out selectedIndex))
                    {
                        if (selectedIndex > 0 && selectedIndex < NameCardList.Length)
                        {
                            Program.EditNameCard(selectedIndex - 1); //명함 수정 전문 메소드
                        }
                    }
                }

            } while (true);

        }

        private static void EditNameCard(int i)
        {
            Console.WriteLine();
            Console.WriteLine("[명함 상세 내용]");
            Program.NameCardList[i].PrintNameCard();

            do
            {
                Console.WriteLine("1. 그룹 변경");
                Console.WriteLine("2. 이름 변경");                
                Console.WriteLine("3. 전화번호 변경");
                Console.WriteLine("4. 기타내용 변경");
                Console.WriteLine("5. 명함 삭제");
                //Console.WriteLine("6. 전화번호 추가"); 이 부분은 구현하고 싶은 친구들 구현 할 것
                Console.WriteLine("0. 명함 선택 화면으로 돌아가기");
                Console.Write(">>");

                string temp = Console.ReadLine();
                switch (temp.Trim())
                {
                    case "1":
                        for (int j = 0; j < NameCard.GroupName.Length; j++)
                        {
                            Console.Write(" {0} : {1}", j + 1, NameCard.GroupName[j]);
                        }

                        Console.Write(" 변경 그룹 >>");
                        temp = Console.ReadLine();
                        int _group = 0;

                        if (!int.TryParse(temp.Trim(), out _group))
                        {
                            Console.WriteLine("그룹 변경에 실패 했습니다.");
                        }
                        else
                        {
                            if ((_group > 0) && (_group <= NameCard.GroupName.Length))
                            {
                                NameCardList[i].SetGroup(_group);
                            }
                            else
                            {
                                Console.WriteLine("그룹 변경에 실패 했습니다.");
                            }
                        }
                        break;
                    case "2":
                        Console.Write(" 이름 >>");
                        //이름의 경우 사용자 입력받은 내용대로 
                        //i번째 NameCard의 SetName을 호출하여 이름을 변경한다.."
                        Program.NameCardList[i].SetName(Console.ReadLine());
                        break;                    
                    case "3":
                        for (int j = 0; j < 5; j++)
                        {
                            if (!string.IsNullOrEmpty(NameCardList[i].GetPhone(j)))
                            {
                                Console.WriteLine(" {0} : {1}", j + 1, NameCardList[i].GetPhone(j));
                            }
                        }

                        int _phoneIdx = 0;
                        Console.Write(" 변경 전화 번호 인덱스>>");
                        temp = Console.ReadLine();
                        if (int.TryParse(temp.Trim(), out _phoneIdx))
                        {
                            if ((_phoneIdx < 1) || (_phoneIdx > 5))
                            {
                                Console.WriteLine("전화번호 변경에 실패 했습니다.");
                            }
                            else
                            {
                                Console.Write(" 변경 전화 번호 >>");
                                NameCardList[i].SetPhone(_phoneIdx - 1, Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("전화번호 변경에 실패 했습니다.");
                        }
                        break;
                    case "4":
                        Console.Write(" 기타내용 >>");
                        Program.NameCardList[i].SetContent(Console.ReadLine());
                        break;
                    case "5":
                        for (int j = 0; j < 5; j++)
                        {
                            if (!string.IsNullOrEmpty(NameCardList[i].GetPhone(j)))
                            {
                                Console.WriteLine(" {0} : {1}", j + 1, NameCardList[i].GetPhone(j));
                            }
                        }
                        int _namecard = 0;
                        Console.Write(" 삭제할 전화 번호 인덱스>>");
                        if (int.TryParse(Console.ReadLine().Trim(), out _namecard))
                        {
                            if((_namecard < 1) || (_namecard > 5))
                            {
                                Console.WriteLine("삭제할 수 없습니다.");
                            }
                            else if (NameCardList[i].RemovePhone(_namecard -1))
                            {
                                Console.Write("삭제완료");
                            }
                            else
                            {
                                Console.Write("삭제불가");
                            }
                        }
                        else
                        {
                            Console.WriteLine("전화번호 변경에 실패 했습니다.");
                        }
                        break;
                    case "6":
                        break; //시간 남으면 구현해 볼 것, 필수 아님
                    case "0":
                        return;
                    default:
                        break;
                }
            } while (true);

        }
    }
}
