using System;

class UnitConverter3{
    // Method to convert Fahrenheit to Celsius
    static double ConvertFahrenheitToCelsius(double fahrenheit){
        double fahrenheit2celsius=(fahrenheit-32)*5/9;
        return fahrenheit2celsius;
    }

    // Method to convert Celsius to Fahrenheit
    static double ConvertCelsiusToFahrenheit(double celsius){
        double celsius2fahrenheit=(celsius*9/5)+32;
        return celsius2fahrenheit;
    }

    // Method to convert pounds to kilograms
    static double ConvertPoundsToKilograms(double pounds){
        double pounds2kilograms=0.453592;
        return pounds*pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    static double ConvertKilogramsToPounds(double kilograms){
        double kilograms2pounds=2.20462;
        return kilograms*kilograms2pounds;
    }

    // Method to convert gallons to liters
    static double ConvertGallonsToLiters(double gallons){
        double gallons2liters=3.78541;
        return gallons*gallons2liters;
    }

    // Method to convert liters to gallons
    static double ConvertLitersToGallons(double liters){
        double liters2gallons=0.264172;
        return liters*liters2gallons;
    }


    static void Main(string[] args){
        // Taking fahrenheit input
        double fahrenheit=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertFahrenheitToCelsius(fahrenheit));

        // Taking celsius input
        double celsius=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertCelsiusToFahrenheit(celsius));

        // Taking pounds input
        double pounds=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertPoundsToKilograms(pounds));

        // Taking kilograms input
        double kilograms=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertKilogramsToPounds(kilograms));

        // Taking gallons input
        double gallons=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertGallonsToLiters(gallons));

        // Taking liters input
        double liters=double.Parse(Console.ReadLine());
        Console.WriteLine(ConvertLitersToGallons(liters));
    }
  }

