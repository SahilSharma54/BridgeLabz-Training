using System;

class QuotientAndRemainder{
    
    // Creating a method to find quotient and remainder
    public static int[] FindRemainderAndQuotient(int number,int divisor){
        int quotient=number/divisor;
        int remainder=number%divisor;
        return new int[]{quotient,remainder};
    }

    static void Main(string[] args){
        
        // Taking input from the user
        int number=int.Parse(Console.ReadLine());
        int divisor=int.Parse(Console.ReadLine());

        int[] result=FindRemainderAndQuotient(number,divisor);

        // Displaying the result
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);
    }
}
