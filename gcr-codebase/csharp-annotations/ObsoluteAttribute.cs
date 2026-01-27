using System;

class LegacyAPI
{
    // Mark old method as obsolete
    [Obsolete("OldFeature is obsolete. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("OldFeature called");
    }

    public void NewFeature()
    {
        Console.WriteLine("NewFeature called");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();

        // Call old method (will show warning)
        api.OldFeature();

        // Call new method
        api.NewFeature();
    }
}
