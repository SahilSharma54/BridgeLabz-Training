using NUnit.Framework;

[TestFixture]
public class ListManagerTests
{
    ListManager manager;

    [SetUp]
    public void Setup()
    {
        manager = new ListManager();
    }

    [Test]
    public void AddElement_Test()
    {
        manager.AddElement(10);
        Assert.AreEqual(1, manager.GetSize());
    }

    [Test]
    public void RemoveElement_Test()
    {
        manager.AddElement(10);
        manager.RemoveElement(10);
        Assert.AreEqual(0, manager.GetSize());
    }
}
