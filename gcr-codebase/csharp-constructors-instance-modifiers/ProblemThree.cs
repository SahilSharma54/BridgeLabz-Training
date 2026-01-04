using System;

class Vehicle{
	
    // Stores the owner's name
    string ownerName;

    // Stores the type of vehicle
    string vehicleType;

    // Static variable shared by all Vehicle objects
    static int registrationFee = 2000;

    // Constructor to initialize vehicle details
    public Vehicle(string owner, string type){
		
        ownerName = owner;
        vehicleType = type;
    }

    // Method to display vehicle information
    public void DisplayVehicleDetails(){
		
        Console.WriteLine("Owner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }

    // Static method to update registration fee
    public static void UpdateRegistrationFee(int fee){
		
        registrationFee = fee;
    }
}

class Program{
	
    static void Main(){
		
        // Update the registration fee using static method
        Vehicle.UpdateRegistrationFee(3000);

        // Create a Vehicle object
        Vehicle v = new Vehicle("Rahul", "Bike");

        // Display vehicle details
        v.DisplayVehicleDetails();
    }
}
