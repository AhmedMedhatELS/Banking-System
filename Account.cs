using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Account
    {
        public Account(string? name, decimal balance = 0)
        {
            Balance = balance;
            Name = name;
        }

        decimal Balance { get; set; }
        string? Name { get; }

        public bool Deposit(decimal deposit)
        {
            if (deposit > 0)
            {
                Balance += deposit;
                return true;
            }
            return false;
        }
        public bool WithDraw(decimal amount)
        {
            if(amount < 0 || amount > Balance)
            {
                return false;
            }
            Balance -= amount;
            return true;
        }
        public void Print()
        {
            Console.WriteLine($"Account Name : {Name}\nBalance = {Balance}");
        }


    }
}
