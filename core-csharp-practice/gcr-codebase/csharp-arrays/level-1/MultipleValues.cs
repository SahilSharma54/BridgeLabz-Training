using System;

class MultipleValues{
	static void Main(String[] args){
		
		// Creating array of given size
		double[] numbers=new double[10];
		
		// Creating variable to store the sum
		double total=0.0;
		
		// Creating variable index
		int index=0;
		
		// infinite loop
		while(true){
		// Taking the value from the user and checking the condition
		double input=double.Parse(Console.ReadLine());
		
		if(input<=0){
			break;
		}
		if(index==10){
			break;
		}
		
		numbers[index]=input;
		
		index++;
		}
		
		// Displaying the results
		for(int iterator=0;iterator<index;iterator++){
			Console.WriteLine(numbers[iterator]);
			total+=numbers[iterator];
		}
		
		// Total Sum
		Console.WriteLine("Sum of all numbers : "+total);
	}
}