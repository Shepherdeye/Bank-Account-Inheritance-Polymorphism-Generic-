using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphoresm
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double intRate = 0.0) : base(name, balance)
        {
            IntRate = intRate;
        }

        public double IntRate { get; set; }

        override public bool Withdraw(double amount)
        {
            return base.Withdraw(amount+(amount*IntRate));
        }

        public override string ToString()
        {
            return $"Name:{Name} Balance :{Balance} IntRate: {IntRate}";
        }


    }
}
