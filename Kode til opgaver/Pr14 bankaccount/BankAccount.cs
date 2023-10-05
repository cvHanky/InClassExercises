using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr14_bankaccount
{
    public class BankAccount
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private double balance;
		public double Balance
		{
			get { return balance; }
		}
		private bool locked;

		public BankAccount(string name, double balance, bool locked)
        {
            Name = name;
            this.balance = balance;
            this.locked = locked;
        }
		public BankAccount(string name, double balance) : this(name, balance, false)
        { 
		}
        public BankAccount(double balance) : this("", balance, false)
        {
        }
		public void Deposit(double amount)
		{
			if (locked == false)
				balance += amount;
			else
				Console.WriteLine("The account is currently locked");
		}
		public void Withdraw(double amount)
		{
			if (locked == false && balance >= amount)
				balance -= amount;
		}
		public void ChangeLockState()
		{
			if (locked)
				locked = false;
			else if (locked == false)
				locked = true;
		}
        public override string ToString()
        {
            return "Name: " + name + ", Balance: " + balance;
        }
    }
}
