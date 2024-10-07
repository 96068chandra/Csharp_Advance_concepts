using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public class AbstractionDemo
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Transaction doing SBI Bank");
            InterfaceExample sbi = Bank.GetBankObject("SBI");
            sbi.BankTransfer();
            sbi.CheckBalanace();
            sbi.ValidateCard();
            sbi.MiniStatement();
            sbi.WithdrawMoney();

            Console.WriteLine("\n Transaction doing via Axis bank");
            InterfaceExample axis = Bank.GetBankObject("AXIS");
            axis.BankTransfer();
            axis.CheckBalanace();
            axis.ValidateCard();
            axis.MiniStatement();
            axis.WithdrawMoney();
            Console.ReadKey();

        }

    }

    public interface InterfaceExample
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }

    public class Bank
    {
        public static InterfaceExample GetBankObject(string bankName)
        {
            InterfaceExample bankObject = null;
            if (bankName == "SBI")
            {
                bankObject = new SBI();
            }

            else if(bankName == "AXIS")
            {
                bankObject = new Axis();
            }
            return bankObject;

        }
    }

    public class SBI : InterfaceExample
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("SBI Balance Check");
        }

        public void MiniStatement()
        {
            Console.WriteLine("SBI Mini Statement check");
        }

        public void ValidateCard()
        {
            Console.WriteLine("SBI Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Withdraw Money");
        }
    }
    public class Axis : InterfaceExample
    {
        public void BankTransfer()
        {
            Console.WriteLine("Axis Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("Axis Balance Check");
        }

        public void MiniStatement()
        {
            Console.WriteLine("Axis Mini Statement check");
        }

        public void ValidateCard()
        {
            Console.WriteLine("Axis Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Axis Withdraw Money");
        }
    }


}
