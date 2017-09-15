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
	}
}
