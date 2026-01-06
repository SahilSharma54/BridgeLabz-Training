
/*

 Vehicle Rental Application
● Concepts: Vehicle, Bike, Car, Truck, Customer.
● Access Modifiers: protected fields.
● Interface: IRentable with CalculateRent(int days).

*/


using System;

// Interface for rent calculation
interface IRentable
{
    double CalculateRent(int days);
}

// Base class
class Vehicle
{
    // Protected field (accessible in child classes)
    protected double ratePerDay;

    public string Model;

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Model: " + Model);
    }
}

// Bike class
class Bike : Vehicle, IRentable
{
    public Bike()
    {
        ratePerDay = 300;
    }

    public double CalculateRent(int days)
    {
        return ratePerDay * days;
    }
}

// Car class
class Car : Vehicle, IRentable
{
    public Car()
    {
        ratePerDay = 800;
    }

    public double CalculateRent(int days)
    {
        return ratePerDay * days;
    }
}

// Truck class
class Truck : Vehicle, IRentable
{
    public Truck()
    {
        ratePerDay = 1500;
    }

    public double CalculateRent(int days)
    {
        return ratePerDay * days;
    }
}

// Customer class
class Customer
{
    public string Name;
}

class RentalProgram
{
    static void Main()
    {
        Customer customer = new Customer();
        customer.Name = "Sahil";

        Vehicle bike = new Bike { Model = "Yamaha" };
        Vehicle car = new Car { Model = "Honda City" };
        Vehicle truck = new Truck { Model = "Tata Truck" };

        Console.WriteLine("Customer: " + customer.Name);
        Console.WriteLine();

        Console.WriteLine("Bike Rent (3 days): " + ((IRentable)bike).CalculateRent(3));
        Console.WriteLine("Car Rent (3 days): " + ((IRentable)car).CalculateRent(3));
        Console.WriteLine("Truck Rent (3 days): " + ((IRentable)truck).CalculateRent(3));
    }
}
