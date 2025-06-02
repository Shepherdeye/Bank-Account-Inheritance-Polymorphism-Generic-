using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphoresm
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0, double fee = 1.50) : base(name, balance)
        {
            Fee = fee;
        }

        public double Fee { get; set; }


        override public bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }
    }
}
