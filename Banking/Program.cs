using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxTechnicalTraining;

namespace Banking {  
	class Program {
		// Run method pushed up to GitHub

		int IncrementValue(int nbr) {
			Console.WriteLine($"The before value of anInt is {nbr}");
			nbr++;
			Console.WriteLine($"The after value of anInt is {nbr}");
			return nbr;
		}

		void Run() { 
			int anInt = 1;
			object obj = "ABC";
			
		}

		void TestAccount() { 
			Account checking = new Account();
			checking.SetName("Checking 1");
			checking.Withdraw(100.00);
			checking.Deposit(50.00);
			checking.Deposit(-100.00);
			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Account savings = new Account("My Savings Account");
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
		}

		static void Main(string[] args) {
			new Program().TestAccount();
		}
	}
}
