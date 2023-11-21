using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class BankAccount
    {
        readonly long AccountNumber;
        string AccountHolderName;
        double Balance;

        public BankAccount(long AccountNumber, string AccountHolderName, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolderName = AccountHolderName;
            this.Balance = Balance;
        }
        public long Account { get { return AccountNumber; } }
        public string Name { get { return AccountHolderName; } }
        public double Bal { get { return Balance; } }


        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited Amount {amount:C}\n Updated balance: {Balance:C}\n");
        }

        public void Withdraw(double amount)
        {

                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}\n Updated balance: {Balance:C}\n");
            
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Available Balance: {Balance:C}");
            Console.WriteLine();
        }
    }
}

