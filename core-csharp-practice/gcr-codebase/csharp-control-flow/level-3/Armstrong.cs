using System;

class Armstrong{
	static void Main(String[] agrs){
		
	// Taking the input number from the user
	int number=int.Parse(Console.ReadLine());
	
	// Storing the original number
	int originalNumber=number;
	
	// Creating variable to store the sum
	int sum=0;
	
	// Using while loop till number not equal to zero and finding remainder 
	while(number!=0){
		
		// Creating digit variable to store the single digits
		int digit=number%10;
		
		sum+=(digit*digit*digit);
		
		// Removing the last number
		number=number/10;
	}
	
    // Checking the condition and print the results
	if(sum==originalNumber){
		Console.WriteLine("It is a Armstrong Number");
	}
	else{
		Console.WriteLine("It is not a Armstrong Number");
	}
  }
}