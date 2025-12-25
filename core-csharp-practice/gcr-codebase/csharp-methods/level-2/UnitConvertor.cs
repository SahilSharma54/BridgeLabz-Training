using System;

class UnitConverter{
    // Method to convert kilometers to miles
    static double ConvertKmToMiles(double kilometers){
        double km2miles=0.621371;
        return kilometers*km2miles;
    }

    // Method to convert miles to kilometers
    static double ConvertMilesToKm(double miles){
        double miles2km=1.60934;
        return miles*miles2km;
    }

    // Method to convert meters to feet
    static double ConvertMetersToFeet(double meters){
        double meters2feet=3.28084;
        return meters*meters2feet;
    }

    // Method to convert feet to meters
    static double ConvertFeetToMeters(double feet){
        double feet2meters=0.3048;
        return feet*feet2meters;
    }



    static void Main(string[] args){
        // Taking kilometers input
        double kilometers=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertKmToMiles(kilometers));

        // Taking miles input
        double miles=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertMilesToKm(miles));

        // Taking meters input
        double meters=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertMetersToFeet(meters));

        // Taking feet input
        double feet=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertFeetToMeters(feet));
    }
  }


