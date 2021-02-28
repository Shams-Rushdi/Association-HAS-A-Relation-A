
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_HAS_A_Relation__A_
{
    class Account
    {
        //private int accountNumber= new Random().Next(1000, 2000);
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;//1-1 Relation
        //private string GenerateUniqueID;



        public Account(int accountNumber,string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }


        public int AccountNumber
        {

            set { this.accountNumber = value; }
            get
            {
                return this.accountNumber;

            }
        }

        static int GenerateDigit(Random rng)
        {
            // Assume there'd be more logic here really
            return rng.Next(10);
        }



        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }


        public void Deposit()
        {
            int _amount = System.Convert.ToInt32(Console.ReadLine());
            Balance += _amount;
            //return Balance;
        }

        public void PrintAccount()
        {
            //Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.address.PrintAddress();
        }

        }
}