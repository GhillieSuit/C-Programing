using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameCardB
{
    class NameCard
    {
        public const int MaxPhoneNumber = 5;
        public static string[] GroupName 
            = { "미분류", "친구", "회사", "가족" };

        private int group;   //0: 미분류 1:친구 2:회사 3: 가족
        private string name;    //이름        
        private string[] phone; //연락처
        private string content; //

        public NameCard(int group, string name,
                     string[] phone, string content)
        {
            this.group = group;
            this.name = name;
            this.phone = phone;
            this.content = content;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetContent()
        {
            return this.content;
        }

        public string GetGroup()
        {
            if (this.group < 0 
                || this.group >= NameCard.GroupName.Length)
            {
                this.group = 0;
            }
            return NameCard.GroupName[this.group];
        }
        
        public string GetPhone(int i)
        {
            if (i < 0 || i >= this.phone.Length)
            {
                return null;
            }
            return this.phone[i];
        }


        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetContent(string content)
        {
            this.content = content;
        }

        public void SetGroup(string group)
        {
            int num = 0;
            if(!string.IsNullOrEmpty(group))
            {
                for (int i = 0; i < GroupName.Length; i++)
                {
                    if(GroupName[i] == group)
                    {
                        num = i;
                        break;
                    }
                }
            }
            this.group = num;
        }

        public void SetGroup(int i)
        {
            if (i < 0 
                || i >= NameCard.GroupName.Length)
            {
                i = 0;
            }

            this.group = i;
        }

        public bool SetPhone(int i, string phone)
        {
            //정책에 따라 달라짐,
            if (i < 0 || i >= this.phone.Length)
            {
                return false;
            }else{
                this.phone[i] = phone;
                return true;
            }
        }

        public bool SetPhone(string phone)
        {
            for (int i = 0; i < this.phone.Length; i++)
            {
                if (string.IsNullOrEmpty(this.phone[i]))
                {
                    this.phone[i] = phone;
                    return true;
                }
            }
            return false;
        }

        public bool RemovePhone(int i)
        {
            if (i < 0)
                return false;

            for (int j = (i + 1); j < this.phone.Length; j++)
            {
                this.phone[j - 1] = this.phone[j];
            }
            return true;
        }

        public void PrintNameCard()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("이름:{0}  그룹:{1}"
                , this.name, NameCard.GroupName[this.group]);
            Console.WriteLine("[연락처]");

            foreach (string number in this.phone)
            {
                if (string.IsNullOrEmpty(number))
                    continue;

                Console.WriteLine("      {0}", number);
            }

            if (!string.IsNullOrEmpty(this.content))
            {
                Console.Write("[기타] ");
                Console.WriteLine(this.content);
            }
            Console.WriteLine("---------------------------------");
        }



    }
}
