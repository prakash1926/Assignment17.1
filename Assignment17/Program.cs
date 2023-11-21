using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(5656,"Ananth",1000);

            account.Deposit(1000);
            account.Withdraw(500);

            account.PrintAccountDetails();

            Console.ReadKey();
        }
    
    }
}
