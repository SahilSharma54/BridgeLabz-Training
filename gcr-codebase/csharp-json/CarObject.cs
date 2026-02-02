using System;
using Newtonsoft.Json;

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

class Program
{
    static void Main()
    {
        Car car = new Car();

        // User input
        Console.Write("Enter car brand: ");
        car.Brand = Console.ReadLine();

        Console.Write("Enter model: ");
        car.Model = Console.ReadLine();

        Console.Write("Enter year: ");
        car.Year = int.Parse(Console.ReadLine());

        // Convert to JSON
        string json = JsonConvert.SerializeObject(car, Formatting.Indented);

        Console.WriteLine("\nCar JSON:");
        Console.WriteLine(json);
    }
}
