using System;

class Trigonometry{
    
    // Creating a method to calculate trigonometric functions
    public static double[] CalculateTrigonometricFunctions(double angle){
        double radians=angle*(3.14/180);  // Converting the angle into radians and using math class methods
        double sine=Math.Sin(radians);
        double cosine=Math.Cos(radians);
        double tangent=Math.Tan(radians);
        return new double[]{sine,cosine,tangent};
    }

    static void Main(string[] args){
        
        // Taking input from the user
        double angle=double.Parse(Console.ReadLine());

        double[] result=CalculateTrigonometricFunctions(angle);

        // Displaying the result
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
        Console.WriteLine(result[2]);
    }
}
