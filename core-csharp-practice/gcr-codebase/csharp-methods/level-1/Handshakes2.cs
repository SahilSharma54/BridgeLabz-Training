using System;

class Handshakes2{
    
    // Creating a method to calculate maximum handshakes
    static int MaximumHandshakes(int numberOfStudents){
        int handshakes=(numberOfStudents*(numberOfStudents-1))/2;
        return handshakes;
    }

    static void Main(string[] args){
        
        // Taking input for number of students
        int numberOfStudents=int.Parse(Console.ReadLine());
        
        // Displaying the number of possible handshakes
        Console.WriteLine(MaximumHandshakes(numberOfStudents));
    }
}
