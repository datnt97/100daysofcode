using System;

namespace ObserverDesignPattern.Stock
{
	public class Investor : IInvestor
	{
		private string name;
		private Stock stock;

		public Investor(string name)
		{
			this.name = name;
		}

		public void Update(Stock stock)
		{
			Console.WriteLine($"Notified {name} of {stock.Symbol}'s change to {stock.Price}");
		}

		public Stock Stock
		{
			get => stock;
			set => stock = value;
		}
	}
}