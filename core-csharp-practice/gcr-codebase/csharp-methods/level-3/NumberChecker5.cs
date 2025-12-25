using System;

class NumberChecker5{
    // Method to find factors of a number
    static int[] FindFactors(int number){
        int count=0;

        // Loop to count factors
        for(int iterator=1;iterator<=number;iterator++){
            if(number%iterator==0){
                count++;
            }
        }

        int[] factors=new int[count];
        int index=0;

        // Loop to store factors
        for(int iterator=1;iterator<=number;iterator++){
            if(number%iterator==0){
                factors[index]=iterator;
                index++;
            }
        }
        return factors;
    }

    // Method to find greatest factor
    static int FindGreatestFactor(int[] factors){
        int greatest=factors[0];
        for(int iterator=0;iterator<factors.Length;iterator++){
            if(factors[iterator]>greatest){
                greatest=factors[iterator];
            }
        }
        return greatest;
    }

    // Method to find sum of factors
    static int FindSumOfFactors(int[] factors){
        int sum=0;
        for(int iterator=0;iterator<factors.Length;iterator++){
            sum+=factors[iterator];
        }
        return sum;
    }

    // Method to find product of factors
    static long FindProductOfFactors(int[] factors){
        long product=1;
        for(int iterator=0;iterator<factors.Length;iterator++){
            product*=factors[iterator];
        }
        return product;
    }

    // Method to find product of cube of factors
    static double FindProductOfCubeOfFactors(int[] factors){
        double product=1;
        for(int iterator=0;iterator<factors.Length;iterator++){
            product*=Math.Pow(factors[iterator],3);
        }
        return product;
    }

    // Method to check perfect number
    static bool IsPerfect(int number,int[] factors){
        int sum=0;
        for(int iterator=0;iterator<factors.Length-1;iterator++){
            sum+=factors[iterator];
        }
        if(sum==number){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to check abundant number
    static bool IsAbundant(int number,int[] factors){
        int sum=0;
        for(int iterator=0;iterator<factors.Length-1;iterator++){
            sum+=factors[iterator];
        }
        if(sum>number){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to check deficient number
    static bool IsDeficient(int number,int[] factors){
        int sum=0;
        for(int iterator=0;iterator<factors.Length-1;iterator++){
            sum+=factors[iterator];
        }
        if(sum<number){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to check strong number
    static bool IsStrong(int number){
        int temp=number;
        int sum=0;

        while(temp>0){
            int digit=temp%10;
            int fact=1;

            for(int iterator=1;iterator<=digit;iterator++){
                fact*=iterator;
            }

            sum+=fact;
            temp/=10;
        }

        if(sum==number){
            return true;
        }
        else{
            return false;
        }
    }

    static void Main(string[] args){
        // Taking input from user
        
        int number=int.Parse(Console.ReadLine());

        int[] factors=FindFactors(number);
		
		// Displaying the results
        Console.WriteLine(FindGreatestFactor(factors));
        Console.WriteLine(FindSumOfFactors(factors));
        Console.WriteLine(FindProductOfFactors(factors));
        Console.WriteLine(FindProductOfCubeOfFactors(factors));
        Console.WriteLine(IsPerfect(number,factors));
        Console.WriteLine(IsAbundant(number,factors));
        Console.WriteLine(IsDeficient(number,factors));
        Console.WriteLine(IsStrong(number));
    }
}
