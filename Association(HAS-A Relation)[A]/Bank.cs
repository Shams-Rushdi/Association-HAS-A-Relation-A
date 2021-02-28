using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Association_HAS_A_Relation__A_
{
    class Bank
    {
        private string name;
        private Account[] accounts;//1-* Relation
        public Bank(string name, int size)
        {
            this.name = name;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }

        public void PrintAllAccounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].PrintAccount();
            }
        }
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        //public void SearchAccount(int accountNo)
        //{
        //    int flag = 0;
        //    for (int i = 0; i < accounts.Length; i++)
        //    {
        //        if (accounts[i] == null)
        //        {
        //            continue;
        //        }
        //        else if (accounts[i].AccountNumber == accountNo)
        //        {
        //            accounts[i].PrintAccount();
        //            flag = 0;
        //            break;
        //        }
        //        else
        //        {
        //            flag = 1;

        //        }
        //    }
        //    if (flag == 1)
        //        Console.WriteLine("Account Not Found");
        //}






        public void PrintAddAccount()
        {
            Bank ourBank = new Bank("Developer's bank", 5);
            Console.WriteLine("      ");
            Console.WriteLine("Account Number: ");
            int acnumber = System.Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Account Holdername: ");
            string name = Console.ReadLine();
            int balance = 0;
            Console.WriteLine("House No: ");
            string houNo = Console.ReadLine();
            Console.WriteLine("Road No:  ");
            string rodNo = Console.ReadLine();
            Console.WriteLine("City Name: ");
            string CitNam = Console.ReadLine();
            Console.WriteLine("Country Name: ");
            string CounNam = Console.ReadLine();
            ourBank.AddAccount(new Account(acnumber, name, balance, new Address(houNo, rodNo, CitNam, CounNam)));
            Console.WriteLine("      ");
            Console.WriteLine("Your Account has been updated ");

        }


        public void DeleteAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accountNo)
                {
                    accounts[i].PrintAccount();
                    flag = 0;
                    for( int j=1; j<accounts.Length; j++)
                    {
                        if(j<accounts.Length-1)
                        {
                            accounts[j] = null;
                            accounts[j] = accounts[j + 1];
                            
                        }
                        else
                        {
                            accounts[j] = null;
                        }
                    }
                    Console.WriteLine("This account has been deleted");
                    //Console.WriteLine("New List......................");
                    break;
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }
    }
}
