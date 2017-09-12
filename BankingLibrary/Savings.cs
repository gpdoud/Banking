using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxTechnicalTraining.BankingLibrary {

	public class Savings : Account {

		public double IntRate { get; set; }

		public void PayMonthlyInterest() {
			var InterestAmount = CheckBalance() * IntRate;
			Deposit(InterestAmount);
		}

		public Savings() : base() {
		}
		public Savings(string name) : base(name) {
		}
		public Savings(string name, double intRate) : base(name) {
			IntRate = intRate;
		}
	}
}
