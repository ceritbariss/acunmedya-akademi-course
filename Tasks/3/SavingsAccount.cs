using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolder, double balance) : base(accountHolder, balance) { }

        public override void CalculateInterest()
        {
            double interest = Balance * 0.05;
            Console.WriteLine($"Interest earned: {interest}");
        }
    }
}
