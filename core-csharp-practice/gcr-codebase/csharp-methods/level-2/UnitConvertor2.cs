using System;

class UnitConverter2{
    // Method to convert yards to feet
    static double ConvertYardsToFeet(double yards){
        double yards2feet=3;
        return yards*yards2feet;
    }

    // Method to convert feet to yards
    static double ConvertFeetToYards(double feet){
        double feet2yards=0.333333;
        return feet*feet2yards;
    }

    // Method to convert meters to inches
    static double ConvertMetersToInches(double meters){
        double meters2inches=39.3701;
        return meters*meters2inches;
    }

    // Method to convert inches to meters
    static double ConvertInchesToMeters(double inches){
        double inches2meters=0.0254;
        return inches*inches2meters;
    }

    // Method to convert inches to centimeters
    static double ConvertInchesToCentimeters(double inches){
        double inches2cm=2.54;
        return inches*inches2cm;
    }

    static void Main(string[] args){
        // Taking yards input
        double yards=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertYardsToFeet(yards));

        // Taking feet input
        double feet=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertFeetToYards(feet));

        // Taking meters input
        double meters=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertMetersToInches(meters));

        // Taking inches input
        double inches=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertInchesToMeters(inches));

        // Taking inches input for centimeters
        inches=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertInchesToCentimeters(inches));
    }
  }

