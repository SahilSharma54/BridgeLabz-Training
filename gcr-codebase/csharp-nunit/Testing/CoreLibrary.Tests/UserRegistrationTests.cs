using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    [Test]
    public void Valid_Registration_Test()
    {
        UserRegistration u = new UserRegistration();
        Assert.DoesNotThrow(() => u.RegisterUser("Sahil", "test@mail.com", "Pass1234"));
    }

    [Test]
    public void Invalid_Registration_Test()
    {
        UserRegistration u = new UserRegistration();
        Assert.Throws<ArgumentException>(() => u.RegisterUser("", "", ""));
    }
}
