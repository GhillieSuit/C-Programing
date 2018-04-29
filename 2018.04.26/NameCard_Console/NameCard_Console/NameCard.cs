using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameCard_Console
{
    class NameCard
    {
        public const int MaxPhoneNumber = 5;
        public static string[] GroupName = { "미분류", "친구", "회사", "가족" };

        int    group;   //0: 미분류 1:친구 2:회사 3: 가족
        string name;    //이름
        string company; //회사
        string address; //주소
        string[] phone; //연락처
        string content; //

        public NameCard(int group, string name, string company, string address, string[] phone, string content)
        {
            this.group = group;
            this.name = name;
            this.company = company;
            this.address = address;
            this.phone = phone;
            this.content = content;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetGroup()
        {
            if (this.group < 0 || this.group >= NameCard.GroupName.Length) {
                this.group = 0;
            }
            return NameCard.GroupName[this.group];
        }

        public string GetCompany()
        {
            return this.company;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public string GetPhone(int i)
        {
            if (i < 0 || i >= this.phone.Length) {
                return null;
            }
            return this.phone[i];
        }

        public string GetContent()
        {
            return this.content;
        }

        public void SetGroup(string group)
        {
            int j = 0;
            if (!string.IsNullOrEmpty(group)) {
                for (int i=0; i < NameCard.GroupName.Length; i++) {
                    if (NameCard.GroupName[i] == group) {
                        j = i;
                        break;
                    }
                }
            }
            this.group = j;
        }

        public void SetGroup(int i)
        {
            if (i < 0 || i >= NameCard.GroupName.Length) {
                i = 0;
            }

            this.group = i;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetCompany(string company)
        {
            this.company = company;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public bool SetPhone(int i, string phone)
        {
            //정책에 따라 달라짐,
            if (i < 0 || i >= this.phone.Length) {
                return false;
            } else {
                this.phone[i] = phone;
                return true;
            }
        }

        public void SetContent(string content)
        {
            this.content = content;
        }

        public void AddPhone(string phone)
        {
            // 이 부분도 정책에 따라 달라짐

            string[] temp = new string[this.phone.Length + 1];
            Array.Copy(this.phone, temp, this.phone.Length);
            temp[temp.Length] = phone;

            this.phone = temp;
        }

        public void RemovePhone(int i)
        {
            if (i < 0)
                return;

            for (int j=(i + 1); j < this.phone.Length; j++) {
                this.phone[j - 1] = this.phone[j];
            }

            //this.phone[this.phone.Length - 1] = null;
            this.phone[this.phone.Length - 1] = null;
        }

        public void PrintNameCard()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("이름:{0}  그룹:{1}", this.name, NameCard.GroupName[this.group]);
            Console.WriteLine("회사:{0}  주소:{1}", this.company, this.address);
            Console.WriteLine("[연락처]");
            foreach (string number in phone) {
                if (string.IsNullOrEmpty(number))
                    continue;
                Console.WriteLine("      {0}", number);
            }
            if (!string.IsNullOrEmpty(this.content)) {
                Console.Write("[기타] ");
                Console.WriteLine(this.content);
            }
            Console.WriteLine("---------------------------------");
        }

    }
}
