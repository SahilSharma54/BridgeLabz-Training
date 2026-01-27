using System;

// Parent class
class Animal
{
    // Virtual method to allow overriding
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

// Derived class
class Dog : Animal
{
    // Override MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        // Create object of Dog
        Dog d = new Dog();
        Console.WriteLine("Calling MakeSound() of Dog:");
        d.MakeSound();
    }
}
