using System;

class NumberChecker2{
    // Method to count digits
    static int CountDigits(int number){
        int count=0;
        while(number>0){
            count++;
            number/=10;
        }
        return count;
    }

    // Method to store digits in array
    static int[] StoreDigits(int number){
        int count=CountDigits(number);
        int[] digits=new int[count];
        for(int iterator=count-1;iterator>=0;iterator--){
            digits[iterator]=number%10;
            number/=10;
        }
        return digits;
    }

    // Method to find sum of digits
    static int FindSumOfDigits(int[] digits){
        int sum=0;
        for(int iterator=0;iterator<digits.Length;iterator++){
            sum+=digits[iterator];
        }
        return sum;
    }

    // Method to find sum of squares of digits
    static int FindSumOfSquares(int[] digits){
        int sum=0;
        for(int iterator=0;iterator<digits.Length;iterator++){
            sum+=(int)Math.Pow(digits[iterator],2);
        }
        return sum;
    }

    // Method to check harshad number
    static bool IsHarshad(int number,int[] digits){
        int sum=FindSumOfDigits(digits);
        if(number%sum==0){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to find frequency of digits
    static int[,] FindDigitFrequency(int[] digits){
        int[,] freq=new int[10,2];

        for(int iterator=0;iterator<10;iterator++){
            freq[iterator,0]=i;
            freq[iterator,1]=0;
        }

        for(int iterator=0;iterator<digits.Length;iterator++){
            freq[digits[iterator],1]++;
        }
        return freq;
    }

    static void Main(string[] args){
        // Given number
        int number=int.Parse(Console.ReadLine());

        // Storing digits
        int[] digits=StoreDigits(number);

        Console.WriteLine(FindSumOfDigits(digits));
        Console.WriteLine(FindSumOfSquares(digits));
        Console.WriteLine(IsHarshad(number,digits));

        int[,] freq=FindDigitFrequency(digits);
        for(int iterator=0;iterator<10;iterator++){
            if(freq[iterator,1]>0){
                Console.WriteLine(freq[iterator,0]);
                Console.WriteLine(freq[iterator,1]);
            }
        }
    }
}
