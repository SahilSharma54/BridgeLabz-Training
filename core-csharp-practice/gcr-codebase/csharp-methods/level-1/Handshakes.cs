using System;

class Handshakes{
    
    // Creating a method to calculate maximum handshakes
    static int MaximumHandshakes(int n){
        int handshakes=(n*(n-1))/2;
        return handshakes;
    }

    static void Main(string[] args){
        
        // Taking input from the user
        int n=int.Parse(Console.ReadLine());
        
        // Calling the method and printing the result
        Console.WriteLine(MaximumHandshakes(n));
    }
}