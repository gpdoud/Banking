using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking { 
	class Account {
		// Properties go here
		private static int nextAccountNumber = 96434;
		private const int incrementAccountNumber = 74747;
		private double Balance = 0;
		private string Name = "Checking";
		private int Number = 0;
		// Methods go here
		private bool IsAmountInvalid(double amount) {
			if(amount > 0) { // this is good
				return false;
			} else { // this is bad
				return true;
			}
		}
		public void Deposit(double amount) {
			if(IsAmountInvalid(amount)) { // this is bad
				Console.WriteLine("Amount must be > zero.");
				return;
			}
			Balance += amount;
		}
		public void Withdraw(double amount) {
			if (IsAmountInvalid(amount)) { // this is bad
				Console.WriteLine("Amount must be > zero.");
				return;
			}
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
		// default constructor
		public Account() {
			Number = nextAccountNumber;
			nextAccountNumber += incrementAccountNumber;
		}
		public Account(string name) {
			Name = name;
			Number = nextAccountNumber;
			nextAccountNumber += incrementAccountNumber;
		}
	}
}
