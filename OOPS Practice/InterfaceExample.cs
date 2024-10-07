using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public interface InterfaceExample1
    {
        bool DepositMoney(decimal amount);
        bool WithdrawMoney(decimal amount);
        decimal CheckBalance();

    }

    public class SavingsAccount : InterfaceExample1
    {
        private decimal balance = 0;
        public readonly decimal withdrawLimitPerDay = 25000;
        private decimal TodayWithdraw = 0;


        public decimal CheckBalance()
        {
           return balance;
        }

        public bool DepositMoney(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"You have Deposited: {amount}");
            Console.WriteLine($"Your Account Balance: {balance}");
            return true;

        }

        public bool WithdrawMoney(decimal amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("You have Insufficient balance!");
                return false;
            }
            else if (TodayWithdraw + amount > withdrawLimitPerDay)
            {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }

            balance -= amount;
            TodayWithdraw = TodayWithdraw + amount;
            Console.WriteLine($"You have Successfully Withdraw: {amount}");
            Console.WriteLine($"Your Account Balance: {balance}");
            return true;

        }
    }
    public class CurrentAccount : InterfaceExample1
    {
        private decimal balance = 0;
        public decimal CheckBalance()
        {
            return balance;
        }

        public bool DepositMoney(decimal amount)
        {
            balance = balance + amount;
            Console.WriteLine($"You have Deposited: {amount}");
            Console.WriteLine($"Your Account Balance: {balance}");
            return true;
        }

        public bool WithdrawMoney(decimal amount)
        {
            if( balance < amount)
            {
                Console.WriteLine("Insufficient Amount");
                return false;
            }
            balance -= amount;
            Console.WriteLine($"You have Successfully Withdraw: {amount}");
            Console.WriteLine($"Your Account Balance: {balance}");
            return true;
        }
    }

    public class Account
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving Account:");
            InterfaceExample1 savingAccount = new SavingsAccount();
            savingAccount.DepositMoney(2000);
            savingAccount.DepositMoney(1000);
            savingAccount.WithdrawMoney(1500);
            savingAccount.WithdrawMoney(5000);
            Console.WriteLine($"Saving Account Balanace: {savingAccount.CheckBalance()}");
            Console.WriteLine("\nCurrent Account:");
            InterfaceExample1 currentAccount = new CurrentAccount();
            currentAccount.DepositMoney(500);
            currentAccount.DepositMoney(1500);
            currentAccount.WithdrawMoney(2600);
            currentAccount.WithdrawMoney(1000);
            Console.WriteLine($"Current Account Balanace: {currentAccount.CheckBalance()}");
            Console.ReadLine();
        }
    }
}
