using System;

class NumberChecker{
	// Method to count digits in a number
    static int CountDigits(int number){
        int count=0;
        while(number>0){
            count++;
            number/=10;
        }
        return count;
    }

	// Method to store digits of a number in array
    static int[] StoreDigits(int number){
        int count=CountDigits(number);
        int[] digits=new int[count];
        for(int iterator=count-1;iterator>=0;iterator--){
            digits[iterator]=number%10;
            number/=10;
        }
        return digits;
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

	// Method to check armstrong number
    static bool IsArmstrong(int number,int[] digits){
        int power=digits.Length;
        int sum=0;
        for(int iterator=0;iterator<digits.Length;iterator++){
            sum+=(int)Math.Pow(digits[iterator],power);
        }
        if(sum==number){
            return true;
        }
        else{
            return false;
        }
    }

	// Method to find largest and second largest digit
    static int[] FindLargestSecondLargest(int[] digits){
        int largest=Int32.MinValue;
        int secondLargest=Int32.MinValue;

        for(int iterator=0;iterator<digits.Length;iterator++){
            if(digits[iterator]>largest){
                secondLargest=largest;
                largest=digits[iterator];
            }
            else if(digits[iterator]>secondLargest&&digits[iterator]!=largest){
                secondLargest=digits[iterator];
            }
        }
        return new int[]{largest,secondLargest};
    }

	// Method to find smallest and second smallest digit
    static int[] FindSmallestSecondSmallest(int[] digits){
        int smallest=Int32.MaxValue;
        int secondSmallest=Int32.MaxValue;

        for(int iterator=0;iterator<digits.Length;iterator++){
            if(digits[iterator]<smallest){
                secondSmallest=smallest;
                smallest=digits[iterator];
            }
            else if(digits[iterator]<secondSmallest&&digits[iterator]!=smallest){
                secondSmallest=digits[iterator];
            }
        }
        return new int[]{smallest,secondSmallest};
    }

    static void Main(string[] args){
		// Given number
        int number=int.Parse(Console.ReadLine());
		
		// Storing digits
        int[] digits=StoreDigits(number);

        Console.WriteLine(CountDigits(number));
        Console.WriteLine(IsDuckNumber(digits));
        Console.WriteLine(IsArmstrong(number,digits));

        int[] large=FindLargestSecondLargest(digits);
        Console.WriteLine(large[0]);
        Console.WriteLine(large[1]);

        int[] small=FindSmallestSecondSmallest(digits);
        Console.WriteLine(small[0]);
        Console.WriteLine(small[1]);
    }
}
