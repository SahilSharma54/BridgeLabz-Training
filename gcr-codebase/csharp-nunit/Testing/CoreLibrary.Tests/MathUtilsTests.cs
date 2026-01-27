using NUnit.Framework;
using System;

[TestFixture]
public class MathUtilsTests
{
    [Test]
    public void Divide_Exception_Test()
    {
        MathUtils math = new MathUtils();
        Assert.Throws<ArithmeticException>(() => math.Divide(10, 0));
    }
}
