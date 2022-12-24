using System;
using System.Collections.Generic;

namespace ObserverDesignPattern.Stock
{
	public abstract class Stock
	{
		private string symbol;
		private double price;

		private List<IInvestor> investors = new List<IInvestor>();

		public Stock(string symbol, double price)
		{
			this.symbol = symbol;
			this.price = price;
		}

		public double Price
		{
			get => price;
			set
			{
				if (price != value)
				{
					price = value;
					NotifyPriceChanged();
				}
			}
		}
		public string Symbol { get => symbol; }


		public void Attach(IInvestor investor)
		{
			investors.Add(investor);
		}

		public void Detach(IInvestor investor)
		{
			investors.Remove(investor);
		}

		public void NotifyPriceChanged()
		{
			foreach (var investor in investors)
			{
				investor.Update(this);
			}

			Console.WriteLine(string.Empty);
		}
	}
}