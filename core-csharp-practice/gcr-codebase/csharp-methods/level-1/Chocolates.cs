using System;

class Chocolates{
    
    // Creating a method to find quotient and remainder
    public static int[] NumberOfChocolates(int number,int divisor){
        int quotient=number/divisor;
        int remainder=number%divisor;
		
        return new int[]{quotient,remainder};
    }

    static void Main(string[] args){
        
        // Taking input from the user
        int numberOfChocolates=int.Parse(Console.ReadLine());
        int numberOfChildren=int.Parse(Console.ReadLine());

        int[] result=NumberOfChocolates(numberOfChocolates,numberOfChildren);

        // Displaying the result
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
    }
}
