using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReLearningCsharp
{
    internal class BankAccount
    {
        public BankAccount(double money, string moneyOwner)
        {
            Money = money;
            MoneyOwner = moneyOwner;
        }

        public double Money { get; set; }
        public string MoneyOwner { get; set; }


        public static BankAccount operator + (BankAccount bank1, BankAccount bank2)
        {
            double totalMoney = bank1.Money + bank2.Money;
            string newOwner = bank1.MoneyOwner + " " + bank2.MoneyOwner;

            BankAccount bank3 = new BankAccount(totalMoney, newOwner);
            return bank3;
        }

    }
}
