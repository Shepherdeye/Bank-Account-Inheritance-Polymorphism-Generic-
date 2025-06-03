using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphoresm
{
    public class TrustAccount : SavingsAccount
    {
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0)
    : base(name, balance, intRate)
        {


            ACCYear = DateTime.Now.Year;
            OperationCounts = 0;

        }

        public int ACCYear { get; set; }
        public int OperationCounts { get; protected set; }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000)

                return base.Deposit(amount + 50);
            else

                return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            int CurrentYear = DateTime.Now.Year;

            if (amount > Balance * 0.20)
            {
                Console.WriteLine($" Over than 20% From {Name}");
                return false;
            }

            if (CurrentYear > ACCYear)
            {
                ACCYear = CurrentYear;
                OperationCounts = 0;
            }

            if (OperationCounts == 3)
            {
                Console.WriteLine(" Failed , More  than 3 times).");
                return false;
            }

            if (base.Withdraw(amount))
            {
                OperationCounts++;
                Console.WriteLine($" Done  and  you have Make : {OperationCounts} times");
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"Name:{Name} Balance :{Balance} IntRate: {IntRate}";
        }

    }
}
