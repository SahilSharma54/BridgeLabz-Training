using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountTests
{
    BankAccount account;

    [SetUp]
    public void Setup()
    {
        account = new BankAccount();
    }

    [Test]
    public void Deposit_Test()
    {
        account.Deposit(500);
        Assert.AreEqual(500, account.Balance);
    }

    [Test]
    public void Withdraw_Insufficient_Funds_Test()
    {
        Assert.Throws<InvalidOperationException>(() => account.Withdraw(100));
    }
}
