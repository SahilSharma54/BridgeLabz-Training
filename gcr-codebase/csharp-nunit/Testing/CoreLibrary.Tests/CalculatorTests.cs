using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    Calculator calc;

    [SetUp]
    public void Setup()
    {
        calc = new Calculator();
    }

    [Test]
    public void Add_Test()
    {
        Assert.AreEqual(10, calc.Add(5, 5));
    }

    [Test]
    public void Divide_ByZero_Test()
    {
        Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
    }
}
