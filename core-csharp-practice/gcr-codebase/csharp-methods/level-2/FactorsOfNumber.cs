using System;

class FactorsOfNumber
{
    // Method to find factors and return them in an array
    static int[] FindFactors(int number)
    {
        // Creating variable to store count of factors
        int count=0;

        // First loop to count factors
        for(int index=1;index<=number;index++){
            if(number%index==0){
                count++;
            }
        }

        // Creating array with factor count
        int[] factors=new int[count];
        int position=0;

        // Second loop to store factors in array
        for(int index=1;index<=number;index++){
            if(number%index==0){
                factors[position]=index;
                position++;
            }
        }

        return factors;
    }

    // Method to find sum of factors
    static int FindSum(int[] factors)
    {
        int sum=0;
        for(int index=0;index<factors.Length;index++){
            sum=sum+factors[index];
        }
        return sum;
    }

    // Method to find product of factors
    static int FindProduct(int[] factors)
    {
        int product=1;
        for(int index=0;index<factors.Length;index++){
            product=product*factors[index];
        }
        return product;
    }

    // Method to find sum of squares of factors
    static int FindSumOfSquares(int[] factors)
    {
        int sumOfSquares=0;
        for(int index=0;index<factors.Length;index++){
            sumOfSquares=sumOfSquares+(int)Math.Pow(factors[index],2);
        }
        return sumOfSquares;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number=int.Parse(Console.ReadLine());

        // Calling method to get factors
        int[] factors=FindFactors(number);

        Console.WriteLine("Factors are:");
        for(int index=0;index<factors.Length;index++){
            Console.WriteLine(factors[index]);
        }

        Console.WriteLine(FindSum(factors));
        Console.WriteLine(FindProduct(factors));
        Console.WriteLine(FindSumOfSquares(factors));
    }
}
