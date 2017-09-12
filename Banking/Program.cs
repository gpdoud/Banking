using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxTechnicalTraining.BankingLibrary;

namespace Banking {  
	class Program {
		// Run method pushed up to GitHub

		void TestAccount() { 
			Account checking = new Account();
			checking.SetName("Checking 1");
			checking.Withdraw(100.00);
			checking.Deposit(50.00);
			checking.Deposit(-100.00);
			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Savings savings = new Savings("My Savings Account");
			savings.IntRate = 0.10;
			savings.Deposit(70.00);
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			savings.Transfer(30.00, checking);

			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			checking.Transfer(-10.00, savings);

			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			savings.Transfer(100.00, checking);

			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			savings.PayMonthlyInterest();

			Console.WriteLine($"Savings Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

			Savings sav1 = new Savings("Greg's Savings with Interest", 0.05);
		}

		static void Main(string[] args) {
			new Program().TestAccount();
		}
	}
}
