using System;

class WindChill{
    
    // Creating a method to calculate wind chill temperature
    public static double CalculateWindChill(double temperature,double windSpeed){
		
		// using the formula given in the question
        double windChill=35.74+0.6215*temperature+(0.4275*temperature-35.75)*Math.Pow(windSpeed,0.16);
        return windChill;
    }

    static void Main(string[] args){
        
        // Taking input from the user
        double temperature=double.Parse(Console.ReadLine());
        double windSpeed=double.Parse(Console.ReadLine());

        // Displaying the result
        Console.WriteLine(CalculateWindChill(temperature,windSpeed));
    }
}
