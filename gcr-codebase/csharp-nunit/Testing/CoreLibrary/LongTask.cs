using System;
using System.Threading;

public class LongTask
{
    public string LongRunningTask()
    {
        // Simulate long work (1 seconds)
        Thread.Sleep(1000);
        return "Done";
    }
}
