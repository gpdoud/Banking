using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaxTechnicalTraining.BankingLibrary;

namespace TestSuiteBanking {

	[TestClass]
	public class AccountTestSuite {

		[TestMethod]
		public void TestInstantiation() {
			Account a = new Account();
			Assert.IsInstanceOfType(a, typeof(Account), "Default constructor");

			Assert.AreEqual(96434, a.getNumber(), "Account number is 96434");

			a = new Account("Test Account");
			Assert.IsInstanceOfType(a, typeof(Account), "Single string constructor");

			Assert.AreEqual(0, a.CheckBalance(), "Balance is zero");

			Assert.AreEqual(96434 + 74747, a.getNumber(), "Account number is 96434+74747");

		}
		[TestMethod]
		public void TestDeposit() {
			Account a = new Account();
			var balance = a.CheckBalance();
			a.Deposit(-100);
			Assert.AreEqual(balance, a.CheckBalance());

			a.Deposit(100);
			Assert.AreEqual(100, a.CheckBalance());
		}
		[TestMethod]
		public void TestWithdraw() {
			Account a = new Account();
			var balance = a.CheckBalance();
			a.Withdraw(-100);
			Assert.AreEqual(balance, a.CheckBalance());

			a.Deposit(100);
			a.Withdraw(100);
			Assert.AreEqual(0, a.CheckBalance());
		}
		[TestMethod]
		public void TestTransfer() {
			Account a = new Account();
			a.Deposit(200);
			Account b = new Account();
			a.Transfer(50, b);
			Assert.AreEqual(150, a.CheckBalance());
			Assert.AreEqual(50, b.CheckBalance());

			a.Transfer(200, b);
			Assert.AreEqual(150, a.CheckBalance());
			Assert.AreEqual(50, b.CheckBalance());
		}
	}
}
