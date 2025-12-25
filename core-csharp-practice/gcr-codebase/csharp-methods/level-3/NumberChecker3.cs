using System;

class NumberChecker3{
    // Method to count digits in a number
    static int CountDigits(int number){
        int count=0;
        while(number>0){
            count++;
            number/=10;
        }
        return count;
    }

    // Method to store digits of number in array
    static int[] StoreDigits(int number){
        int count=CountDigits(number);
        int[] digits=new int[count];
        for(int iterator=count-1;iterator>=0;iterator--){
            digits[iterator]=number%10;
            number/=10;
        }
        return digits;
    }

    // Method to reverse digits array
    static int[] ReverseDigits(int[] digits){
        int[] reverse=new int[digits.Length];
        int index=0;
        for(int iterator=digits.Length-1;iterator>=0;iterator--){
            reverse[index]=digits[iterator];
            index++;
        }
        return reverse;
    }

    // Method to compare two arrays
    static bool CompareArrays(int[] first,int[] second){
        if(first.Length!=second.Length){
            return false;
        }

        for(int iterator=0;iterator<first.Length;iterator++){
            if(first[iterator]!=second[iterator]){
                return false;
            }
        }
        return true;
    }

    // Method to check palindrome number
    static bool IsPalindrome(int[] digits){
        int[] reverse=ReverseDigits(digits);
        return CompareArrays(digits,reverse);
    }

    // Method to check duck number
    static bool IsDuckNumber(int[] digits){
        for(int iterator=0;iterator<digits.Length;iterator++){
            if(digits[iterator]!=0){
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args){
        // Taking number input from user
        int number=int.Parse(Console.ReadLine());

        // Storing digits
        int[] digits=StoreDigits(number);

        Console.WriteLine(CountDigits(number));
        Console.WriteLine(IsPalindrome(digits));
        Console.WriteLine(IsDuckNumber(digits));
    }
}
