using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    [Test]
    public void Valid_Password_Test()
    {
        PasswordValidator v = new PasswordValidator();
        Assert.IsTrue(v.IsValid("Password1"));
    }

    [Test]
    public void Invalid_Password_Test()
    {
        PasswordValidator v = new PasswordValidator();
        Assert.IsFalse(v.IsValid("pass"));
    }
}
