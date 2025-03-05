using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public virtual void CalculateInterest()
        {
            Console.WriteLine("This account does not have an interest calculation defined.");
        }
    }
}
