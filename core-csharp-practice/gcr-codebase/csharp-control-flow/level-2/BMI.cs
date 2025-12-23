using System;

class BMI{
	static void Main(String[] args){
		
		// Taking the value of weight and height from the user
		double weight=double.Parse(Console.ReadLine());
		double height=double.Parse(Console.ReadLine());
		
		// Taking the variable for BMI Calculation
		double bmi=0;
		
		// Converting the value of height from cm to m
		height=height/100;
		
		// Performing the calculation of BMI
		bmi=weight/(height*height);
		
		// Checking the condition for the status and displaying the result
		if(bmi<=18.4){
			Console.WriteLine("UnderWeight");
		}
		else if(bmi>=18.5&&bmi<=24.9){
			Console.WriteLine("Normal");
		}
		else if(bmi>=25.0&&bmi<=39.9){
			Console.WriteLine("OverWeight");
		}
		else if(bmi>=40.0){
			Console.WriteLine("Obese");
		}
		
	}
}