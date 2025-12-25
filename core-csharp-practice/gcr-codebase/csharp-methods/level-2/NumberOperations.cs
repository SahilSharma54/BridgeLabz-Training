using System;

class NumberOperations{
    // Method to check positive or negative
    static bool IsPositive(int number){
        if(number>=0){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to check even or odd
    static bool IsEven(int number){
        if(number%2==0){
            return true;
        }
        else{
            return false;
        }
    }

    // Method to compare two numbers
    static int CompareNumbers(int number1,int number2){
        if(number1>number2){
            return 1;
        }
        else{
            if(number1==number2){
                return 0;
            }
            else{
                return -1;
            }
        }
    }

    static void Main(string[] args){
        // Creating array for numbers
        int[] numbers=new int[5];

        // Taking input values
        for(int index=0;index<numbers.Length;index++){
            numbers[index]=int.Parse(Console.ReadLine());

            if(IsPositive(numbers[index])){
                if(IsEven(numbers[index])){
                    Console.WriteLine("Even");
                }
                else{
                    Console.WriteLine("Odd");
                }
            }
            else{
                Console.WriteLine("Negative");
            }
        }
		
		// Checking the number given
        int result=CompareNumbers(numbers[0],numbers[numbers.Length-1]);

        if(result==1){
            Console.WriteLine("Greater");
        }
        else{
            if(result==0){
                Console.WriteLine("Equal");
            }
            else{
                Console.WriteLine("Less");
            }
        }
    }
}
