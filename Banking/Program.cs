using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {  
	class Program {
		// Run method pushed up to GitHub
		void Run() {
			Account checking = new Account();
			checking.SetName("Checking 1");
			checking.Withdraw(100.00);
			checking.Deposit(50.00);
			checking.Deposit(-100.00);
			Console.WriteLine($"Account Nbr:{checking.getNumber()}, Name: {checking.GetName()}, balance is {checking.CheckBalance()}");
			Account savings = new Account("My Savings Account");
			savings.Deposit(70.00);
			Console.WriteLine($"Account Nbr:{savings.getNumber()}, Name: {savings.GetName()}, balance is {savings.CheckBalance()}");

		}

		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
