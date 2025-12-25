using System;

class CheckNumber{
    
    // Creating a method to check number type
    static int CheckValue(int number){
        if(number>0){
            return 1;
        }
        else if(number<0){
            return -1;
        }
        else{
            return 0;
        }
    }

    static void Main(string[] args){
        
        // Taking input from the user
        int number=int.Parse(Console.ReadLine());
        
        // Displaying the result
        Console.WriteLine(CheckValue(number));
    }
}
