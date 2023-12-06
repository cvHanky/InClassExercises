using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr34_Sparegris_bonus
{
	public delegate void SparegrisBonusEventHandler(object sender, EventArgs e);
    public class Sparegris
    {
		private double amount;
		public double Amount
		{
			get { return amount; }
			set { amount = value; OnAmountChanged(); }
		}
		public Sparegris()
		{
			amount = 0;
		}

		public event SparegrisBonusEventHandler AmountChanged;
		public void OnAmountChanged()
		{
			if (AmountChanged != null)
			{
				AmountChanged(this,null);
			}
		}
		public void InsertAmount(double amount)
		{
			Amount += amount;
		}
		public void Update(object sender, EventArgs e)
		{
			if (sender is Sparegris piggy)
			{
                Console.WriteLine($"New amount is: {piggy.amount}");

				if (piggy.amount >= 399 && piggy.amount < 799)
                    Console.WriteLine("Tillyke - du har nu penge nok til et sæsonkort til OB's kampe.");
                else if (piggy.amount >= 799 && piggy.amount < 1197)
                    Console.WriteLine("Tillyke - du har nu penge nok til et premium sæsonkort til OB's kampe.");
                else if (piggy.amount >= 1197)
                    Console.WriteLine("Tillyke - du har nu penge nok til tre sæsonkort til OB's kampe.");
			}
		}
	}
}
