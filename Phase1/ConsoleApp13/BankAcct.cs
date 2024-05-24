using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class BankAcct
    {
        private Object acctlock = new Object();
        double Balance { get; set; }
        string Name {  get; set; }
        public BankAcct(double bal)
        {
            Balance = bal;
        }
        public double Withdraw(double amt)
        {
            if((Balance -amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }
            lock (acctlock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account",
                    amt, (Balance - amt));
                    Balance -= amt;
                }

                return Balance;

            }

        }
        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
}
