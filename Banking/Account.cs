using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking {
	class Account {
		// Properties go here
		private double Balance = 0;
		private string Name = "Checking";
		private int Number = 0;
		// Methods go here
		public void Deposit(double amount) {
			Balance += amount;
		}
		public void Withdraw(double amount) {
			if (amount > CheckBalance()) {
				Console.WriteLine("Insufficient funds.");
			} else {
				Balance -= amount;
			}
		}
		public double CheckBalance() {
			return Balance;
		}
		public string GetName() {
			return Name;
		}
		public void SetName(string name) {
			Name = name;
		}
		public int getNumber() {
			return Number;
		}
		private void SetNumber(int number) {

		}
		public Account() {

		}
		public Account(string name) {
			Name = name;
		}
	}
}
