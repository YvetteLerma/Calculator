using System;
namespace Calculator
{
	public class CalculatorApp
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Simple Calculator Menu:");
			Console.WriteLine("1. Addition");
			Console.WriteLine("2. Subtraction");

			Console.WriteLine("Choose an operation between (1-5): ");
			string picked = Console.ReadLine();
		}
	}
}

