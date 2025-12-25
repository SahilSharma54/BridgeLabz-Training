using System;

class SumOfNaturalNumbers{
    
    // Creating a method to find sum of n natural numbers
    static int FindSum(int number){
        int sum=0;
        for(int i=1;i<=number;i++){
            sum=sum+i;
        }
        return sum;
    }

    static void Main(string[] args){
        
        // Taking input from the user
        int number=int.Parse(Console.ReadLine());
        
        // Displaying the result
        Console.WriteLine(FindSum(number));
    }
}
