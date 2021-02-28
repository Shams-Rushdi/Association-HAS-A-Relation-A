using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Association_HAS_A_Relation__A_;

namespace Association_HAS_A_Relation__A_
{
    class Program
    {

        static void Main(string[] args)
        {


            //Random rng = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(GenerateDigit(rng));
            //}


            //Address address1 = new Address(4,10,"Dhaka");
            //Account account1 = new Account(1001, "Shakib", 2000, address1);
            //account1.PrintAccount();

            //Account account2 = new Account(1002,"Tamim",3000,new Address(7,20,"Chittagong"));
            //account2.PrintAccount();




            Bank ourBank = new Bank("Developer's bank", 5);
            ourBank.AddAccount(new Account(1001,"Shakib", 2000, new Address("4", "10", "Dhaka","Bangladesh")));
            ourBank.AddAccount(new Account(1002,"Mushfiq", 5000, new Address("5", "15", "Sylhet", "USA")));
            ourBank.AddAccount(new Account(1003,"Tamim", 3000, new Address("10","20", "Chittagong","Uganda")));
            //ourBank.PrintAllAccounts();
            
            //ourBank.SearchAccount(1001);

            //ourBank.DeleteAccount(1001);
            //ourBank.PrintAllAccounts();

            Console.WriteLine("1. Withdraw ");
            Console.WriteLine("2. Deposit ");
            Console.WriteLine("3. Transfer ");
            Console.WriteLine("4. AddAccount ");
            Console.WriteLine("5. DeleteAccount ");
            Console.WriteLine("6. Transaction ");
            Console.WriteLine("      ");
            Console.WriteLine("Enter the operation: ");
            int num = System.Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine("      ");
                ourBank.PrintAllAccounts();
            }
            else if(num ==2 )
            {
                Console.WriteLine("      ");
                Console.WriteLine("Please give your Account number:");
                int acnumber = System.Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please give your deposite amount:");
                //int _amount = System.Convert.ToInt32(Console.ReadLine());
                ourBank.Deposit();
                //doDeposit()





            }
            else if (num == 3)
            {
                Console.WriteLine("      ");
            }
            else if (num == 4)
            {
                Console.WriteLine("      ");
                ourBank.PrintAddAccount();
            

            }
            else if (num == 5)
            {
                Console.WriteLine("      ");
                Console.WriteLine("Enter Account Number");
                int acnumber = System.Convert.ToInt32(Console.ReadLine());
                ourBank.DeleteAccount(acnumber);

            }
            else if (num == 6)
            {
                Console.WriteLine("      ");

            }


        }
    }
}
