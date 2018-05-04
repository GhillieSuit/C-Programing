using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_management
{
    class Account
    {
        private string AccountNumber;    //계좌번호
        private string Owner;            //소유자
        private int Balance;             //잔액

        public Account(string AccountNumber, string Owner) //사용자 정의 생성
        {
            this.AccountNumber = AccountNumber;
            this.Owner = Owner;
        }

        public Account(string AccountNumber, string Owner, int Balance) : this(AccountNumber, Owner)
        {
            this.Balance = Balance;
        }

        public int Deposit(int amount)
        {
            Console.WriteLine("=========[입금 처리]=========");
            Console.WriteLine("▶입금액 : {0}", amount);
            this.Balance += amount;
            this.AccountInfo();
            return this.Balance;
        }

        public int Withdraw(int amount)
        {
            Console.WriteLine("=========[출금 처리]=========");
            Console.WriteLine("▶출금액 : {0}", amount);
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("[잔고부족]");
            }
            this.AccountInfo();
            Console.WriteLine();
            return this.Balance;
        }

        public void AccountInfo()
        {
            Console.WriteLine("계좌번호 : {0}", this.AccountNumber);
            Console.WriteLine("소유자명 : {0}", this.Owner);
            Console.WriteLine("잔액 : {0}", this.Balance);
            Console.WriteLine();
        }
    }

    class Bank
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001-23456-02-1234", "Liam", 2000);
            Account acc2 = new Account("001-23456-02-5678", "Noah", 12000);
            Account acc3 = new Account("001-23456-02-9012", "Logan");

            acc1.Deposit(200);
            acc2.Deposit(3000);
            acc1.Deposit(20000);

            acc1.Withdraw(20000);
            acc2.Withdraw(20000);

            acc1.AccountInfo();
            acc2.AccountInfo();
            acc3.AccountInfo();
        }
    }
}
