using System;

class TriangleRun{
    
    // Creating a method to calculate number of rounds
    static int CalculateRounds(int side1,int side2,int side3){
        int perimeter=side1+side2+side3;
        int rounds=5000/perimeter;
        return rounds;
    }

    static void Main(string[] args){
        
        // Taking input for three sides of triangle
        int side1=int.Parse(Console.ReadLine());
        int side2=int.Parse(Console.ReadLine());
        int side3=int.Parse(Console.ReadLine());
        
        // Displaying number of rounds
        Console.WriteLine(CalculateRounds(side1,side2,side3));
    }
}
