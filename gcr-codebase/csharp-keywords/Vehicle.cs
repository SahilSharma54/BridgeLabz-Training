using System;

class Vehicle{
	
    // static variable
    public static int RegistrationFee = 3000;

    // readonly variable
    public readonly string RegistrationNumber;

    // instance variables
    public string OwnerName;
    public string VehicleType;

    // constructor using 'this'
    public Vehicle(string regNo, string owner, string type){
		
        this.RegistrationNumber = regNo;
        this.OwnerName = owner;
        this.VehicleType = type;
    }

    // static method
    public static void UpdateRegistrationFee(int fee){
		
        RegistrationFee = fee;
    }

    // display method
    public void DisplayDetails(){
		
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Fee: " + RegistrationFee);
    }
}

class Program{
	
    static void Main(){
		
        Vehicle v1 = new Vehicle("UP801234", "Sahil", "Car");

        // is operator
        if (v1 is Vehicle){
			
            v1.DisplayDetails();
        }

        Vehicle.UpdateRegistrationFee(4500);
        Console.WriteLine("Updated Registration Fee: " + Vehicle.RegistrationFee);
    }
}
