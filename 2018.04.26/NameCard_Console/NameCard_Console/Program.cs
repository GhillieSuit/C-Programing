using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameCard_Console
{
    class Program
    {
        static NameCard[] NameCardList;
        static int Count=0;
        
        static void EditNameCard(int i)
        {
            Console.WriteLine();
            Console.WriteLine("[명함 상세 내용]");
            Program.NameCardList[i].PrintNameCard();

            do {
                Console.WriteLine("1. 그룹 변경");
                Console.WriteLine("2. 이름 변경");
                Console.WriteLine("3. 회사 변경");
                Console.WriteLine("4. 주소 변경");
                Console.WriteLine("5. 전화번호 변경");
                Console.WriteLine("6. 기타내용 변경");
                Console.WriteLine("7. 변경 종료");
                Console.WriteLine("10. 명함 삭제");
                Console.Write(">>");

                string temp = Console.ReadLine();
                switch (temp.Trim()) {
                    case "1":
                        for (int j=0; j < NameCard.GroupName.Length; j++) {
                            Console.Write("   {0}:{1}", j + 1, NameCard.GroupName[j]);
                        }
                        Console.Write(" 변경 그룹 >>");
                        temp = Console.ReadLine();
                        int _group = 0;
                        if (!int.TryParse(temp.Trim(), out _group)) {
                            Console.WriteLine("그룹 변경에 실패 했습니다.");
                        } else {
                            if (_group > 0 && _group <= NameCard.GroupName.Length) {
                                Program.NameCardList[i].SetGroup(_group);
                            } else {
                                Console.WriteLine("그룹 변경에 실패 했습니다.");
                            }
                        }
                        break;
                    case "2":
                        Console.Write(" 이름 >>");
                        Program.NameCardList[i].SetName(Console.ReadLine());                        
                        break;
                    case "3":
                        Console.Write(" 회사 >>");
                        Program.NameCardList[i].SetCompany(Console.ReadLine());                        
                        break;
                    case "4":
                        Console.Write(" 주소 >>");
                        Program.NameCardList[i].SetAddress(Console.ReadLine());                        
                        break;
                    case "5":
                        for (int j=0; j < NameCard.MaxPhoneNumber; j++) {
                            if (!string.IsNullOrEmpty(Program.NameCardList[i].GetPhone(j)))
                                Console.WriteLine("   {0}:{1}", j + 1, Program.NameCardList[i].GetPhone(j));
                        }

                        int _phoneIdx = 0; 
                        Console.Write(" 변경 전화 번호 인덱스>>");
                        temp = Console.ReadLine();
                        if (int.TryParse(temp.Trim(), out _phoneIdx)) {
                            if (_phoneIdx < 1 || _phoneIdx > NameCard.MaxPhoneNumber) {
                                Console.WriteLine("전화번호 변경에 실패 했습니다.");
                            } else {
                                Console.Write(" 변경 전화 번호 >>");
                                Program.NameCardList[i].SetPhone(_phoneIdx - 1, Console.ReadLine());
                            }
                        } else {
                            Console.WriteLine("전화번호 변경에 실패 했습니다.");
                        }
                        break;
                    case "6":
                        Console.Write(" 기타내용 >>");
                        Program.NameCardList[i].SetContent(Console.ReadLine());                        
                        break;                        
                    case "7":
                        return;
                    case "10":
                        //이 부분은 어떻게 구현하면 좋을까?
                        return;
                    default:
                        break;
                }                

            } while (true);

        }

        static void ManageNameCard()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++");
            Console.WriteLine("+ 명 함 관 리 +");
            Console.WriteLine("++++++++++++++");

            if (Program.NameCardList == null || Program.Count == 0) {
                Console.WriteLine("관리할 명함이 존재하지 않음");
                return;
            }


            do {
                Console.WriteLine("명함목록");
                for (int i=0; i < Program.NameCardList.Length; i++) {
                    if(Program.NameCardList[i] != null)
                        Console.WriteLine("{0}: {1}", i + 1, Program.NameCardList[i].GetName());
                }
                Console.WriteLine("------------------------------------");
                Console.Write("관리하려는 명함 번호를 입력(메인으로 이동 시 Q입력) >>");

                string temp = Console.ReadLine();
                if (temp.Trim().ToUpper() == "Q") {
                    return;
                } else {
                    int selectedIndex = 0;
                    if (int.TryParse(temp.Trim(), out selectedIndex)) {
                        if (selectedIndex > 0 && selectedIndex < Program.NameCardList.Length) {
                            Program.EditNameCard(selectedIndex-1);
                        }
                    }
                }



            } while (true);
            
        }

        static NameCard GetNewNameCard()
        {
            Console.WriteLine("++++++++++++++");
            Console.WriteLine("+ 명 함 입 력 +");
            Console.WriteLine("++++++++++++++");

            int    group;   //0: 미분류 1:친구 2:회사 3: 가족
            string name;    //이름
            string company; //회사
            string address; //주소
            string[] phone = new string[NameCard.MaxPhoneNumber]; //연락처
            string content; //

            string temp;

            Console.WriteLine();
            Console.WriteLine("그룹을 결정해주세요.(번호 입력)");
            for (int i=0; i < NameCard.GroupName.Length; i++) {
                Console.WriteLine("{0}:{1}", i + 1, NameCard.GroupName[i]);
            }
            Console.Write(">> ");
            temp = Console.ReadLine();

            if (!int.TryParse(temp, out group)) {
                group = 0;
            } else {
                if (group < 0 || group >= NameCard.GroupName.Length) {
                    group = 0;
                }
            }

            Console.WriteLine("이름을 넣어주세요.");
            Console.Write(">> ");
            name = Console.ReadLine();

            Console.WriteLine("회사를 넣어주세요.");
            Console.Write(">> ");
            company = Console.ReadLine();

            Console.WriteLine("주소를 넣어주세요.");
            Console.Write(">> ");
            address = Console.ReadLine();

            Console.WriteLine("전화번호 넣어주세요. (최대 5개 가능");            
            for (int i=0; i < NameCard.MaxPhoneNumber; i++) {
                Console.Write("{0}번 >> ", i+1);
                temp = Console.ReadLine();

                if (string.IsNullOrEmpty(temp)) {
                    break;
                } else {
                    phone[i] = temp;
                }
            }

            Console.WriteLine("항목 외 정보를 넣어주세요.");
            Console.Write(">> ");
            content = Console.ReadLine();

            NameCard nc = new NameCard(group, name, company, address, phone, content);

            
            Console.WriteLine("[입력한 명함의 전체 정보]");
            nc.PrintNameCard();            

            return nc;

        }

        static void Main(string[] args)
        {   

            Program.NameCardList = new NameCard[10];

            do {
                Console.WriteLine("===================================");
                Console.WriteLine("=  명 함 입 력 / 관 리 프 로 그 램  =");
                Console.WriteLine("===================================");

                Console.WriteLine("1. 명함 입력");
                Console.WriteLine("2. 명함 관리");
                Console.WriteLine("3. 종료");
                Console.WriteLine("-----------------------------------");
                string menu = Console.ReadLine();

                switch (menu.Trim()) {
                    case "1" :
                        
                        if (Program.Count < Program.NameCardList.Length) {
                            NameCard nameCard = Program.GetNewNameCard();
                            if (nameCard != null) {
                                Program.NameCardList[Program.Count++] = nameCard;
                            }
                        } else {
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
    }
}
