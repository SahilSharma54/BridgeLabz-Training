using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterTests
{
    [Test]
    public void Valid_Date_Test()
    {
          DateFormatter f = new DateFormatter();
          Assert.AreEqual("15/08/2024", f.FormatDate("2024-08-15")); 
    }

    [Test]
    public void Invalid_Date_Test()
    {
        DateFormatter f = new DateFormatter();
        Assert.Throws<FormatException>(() => f.FormatDate("15/08/2024"));
    }
}
