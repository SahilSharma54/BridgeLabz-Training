using System;

class CarRental{
	
    string customerName;
    string carModel;
    int rentalDays;

    public CarRental(string name, string model, int days){
		
        customerName = name;
        carModel = model;
        rentalDays = days;
    }

    public void CalculateCost(){
		
        int costPerDay = 1000;
        int totalCost = costPerDay * rentalDays;

        Console.WriteLine("Customer: " + customerName);
        Console.WriteLine("Car Model: " + carModel);
        Console.WriteLine("Total Cost: " + totalCost);
    }
}

class Program{
	
    static void Main(){
		
        CarRental c = new CarRental("Rahul", "Honda City", 3);
        c.CalculateCost();
    }
}
