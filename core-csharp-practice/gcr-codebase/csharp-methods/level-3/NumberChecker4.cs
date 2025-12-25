using System;

class NumberChecker4{
    // Method to check prime number
    static bool IsPrime(int number){
        if(number<=1){
            return false;
        }

        for(int iterator=2;iterator<=number/2;iterator++){
            if(number%iterator==0){
                return false;
            }
        }
        return true;
    }

    // Method to check neon number
    static bool IsNeon(int number){
        int square=number*number;
        int sum=0;

        while(square>0){
            sum+=square%10;
            square/=10;
        }

        if(sum==number){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to check spy number
    static bool IsSpy(int number){
        int sum=0;
        int product=1;
        int temp=number;

        while(temp>0){
            int digit=temp%10;
            sum+=digit;
            product*=digit;
            temp/=10;
        }

        if(sum==product){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to check automorphic number
    static bool IsAutomorphic(int number){
        int square=number*number;
        int temp=number;

        while(temp>0){
            if(square%10!=temp%10){
                return false;
            }
            square/=10;
            temp/=10;
        }
        return true;
    }

    // Method to check buzz number
    static bool IsBuzz(int number){
        if(number%7==0||number%10==7){
            return true;
        }
        else{
            return false;
        }
    }

    static void Main(string[] args){
        // Taking input from user
        
        int number=int.Parse(Console.ReadLine());
		
		// Displaying the result
		
        Console.WriteLine(IsPrime(number));
        Console.WriteLine(IsNeon(number));
        Console.WriteLine(IsSpy(number));
        Console.WriteLine(IsAutomorphic(number));
        Console.WriteLine(IsBuzz(number));
    }
}
