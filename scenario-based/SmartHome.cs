using System;

// Interface 
interface IControllable
{
    void TurnOn();
    void TurnOff();
}

// Light Class 
class Light : IControllable
{
    string name;

    public Light(string name)
    {
        this.name = name;
    }

    public void TurnOn()
    {
        Console.WriteLine(name + " Light is turned ON with bright light.");
    }

    public void TurnOff()
    {
        Console.WriteLine(name + " Light is turned OFF.");
    }
}

// Fan Class 
class Fan : IControllable
{
    string name;

    public Fan(string name)
    {
        this.name = name;
    }

    public void TurnOn()
    {
        Console.WriteLine(name + " Fan is running at medium speed.");
    }

    public void TurnOff()
    {
        Console.WriteLine(name + " Fan is turned OFF.");
    }
}

// AC Class 
class AC : IControllable
{
    string name;

    public AC(string name)
    {
        this.name = name;
    }

    public void TurnOn()
    {
        Console.WriteLine(name + " AC is cooling the room to 22°C.");
    }

    public void TurnOff()
    {
        Console.WriteLine(name + " AC is turned OFF.");
    }
}

//  Main Class 
class SmartHome
{
    static void Main(string[] args)
    {
        Console.WriteLine("SMART HOME AUTOMATION SYSTEM");
        Console.WriteLine("1. Light");
        Console.WriteLine("2. Fan");
        Console.WriteLine("3. AC");
        Console.Write("Choose Appliance: ");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("1. Turn ON");
        Console.WriteLine("2. Turn OFF");
        Console.Write("Choose Action: ");

        int action = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Light light = new Light("Living Room");

            if (action == 1)
                light.TurnOn();
            else
                light.TurnOff();
        }
        else if (choice == 2)
        {
            Fan fan = new Fan("Bedroom");

            if (action == 1)
                fan.TurnOn();
            else
                fan.TurnOff();
        }
        else if (choice == 3)
        {
            AC ac = new AC("Hall");

            if (action == 1)
                ac.TurnOn();
            else
                ac.TurnOff();
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }
}
