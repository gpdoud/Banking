using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	class Program {

		void Run() {
			Account checking = new Account();
			checking.SetName("Checking 1");
			checking.Withdraw(100.00);
			checking.Deposit(50.00);
			checking.Deposit(-100.00);
			Console.WriteLine($"Account {checking.GetName()}, balance is {checking.CheckBalance()}");
		}

		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
