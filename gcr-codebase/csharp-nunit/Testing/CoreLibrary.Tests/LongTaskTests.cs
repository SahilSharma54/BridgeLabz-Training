using NUnit.Framework;

[TestFixture]
public class LongTaskTests
{
    [Test]
    [Timeout(2000)] // Fail if method takes more than 2 seconds
    public void LongRunningTask_Performance_Test()
    {
        LongTask task = new LongTask();
        task.LongRunningTask();
    }
}
