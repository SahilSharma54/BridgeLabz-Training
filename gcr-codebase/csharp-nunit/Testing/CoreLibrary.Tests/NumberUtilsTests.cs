using NUnit.Framework;

[TestFixture]
public class NumberUtilsTests
{
    [TestCase(2)]
    [TestCase(4)]
    [TestCase(6)]
    [TestCase(8)]
    public void IsEven_Test(int number)
    {
        NumberUtils utils = new NumberUtils();
        Assert.IsTrue(utils.IsEven(number));
    }
}
