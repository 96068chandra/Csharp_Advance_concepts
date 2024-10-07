using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Practice
{
    public class EncapsulationDemo
    {
        private int balance;

        public int GetBalance()
        {
            return balance;
        }

        public void SetBalance(int balance)
        {
            if(balance < 0)
            {
                throw new Exception("Balance should be positive");

            }
            this.balance = balance;
        }

        private double _amount;

        public double amount
        {
            get { return _amount; }
            set
            {
                if(value>0)
                {
                    _amount = value;

                }
                else
                {
                    throw new Exception("Amount should be positive");
                }
            }
        }
    }
    public class Program1
    {
        static void Main3(string[] args)
        {
            EncapsulationDemo demo = new EncapsulationDemo();
            Console.WriteLine(demo.GetBalance());
            demo.SetBalance(1000);
            Console.WriteLine( demo.GetBalance());
          //  demo.SetBalance(-21);
            Console.WriteLine(demo.GetBalance());
            demo.amount = -10;
            Console.WriteLine(demo.amount);
            Console.ReadKey();

        }
    }
}
