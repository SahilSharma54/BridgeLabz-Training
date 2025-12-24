using System;

class MeanHeight{
	static void Main(String[] args){
		
		// Creating a array with the given size
		double[] height=new double[11];
		
		// Creating a variable for the sum
		double sum=0;
		
		// Creating a variable for the meanHeight
		double meanHeight=0.0;
		
		// Taking the input from the user for heights
		for(int iterator=0;iterator<height.Length;iterator++){
			
			height[iterator]=double.Parse(Console.ReadLine());
			
			// Taking the sum also
			sum+=height[iterator];
			
		}
		
		meanHeight=sum/11;
		
		// Displaying the results
		Console.WriteLine(meanHeight);
		
	}
}