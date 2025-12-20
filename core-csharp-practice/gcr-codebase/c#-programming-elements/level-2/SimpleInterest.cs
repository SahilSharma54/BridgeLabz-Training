using System;

class SimpleInterest{
	static void Main(String[] args){
		 
		 // Creating variables for storing values of principal, rate of interest, time from the user
		 int principal=int.Parse(Console.ReadLine());
		 int rate=int.Parse(Console.ReadLine());
		 int time=int.Parse(Console.ReadLine());
		 
		 // Calculating the simple interest 
		 int simpleInterest=(principal*rate*time)/100;
		 
		 // Displaying the results
		 Console.WriteLine("The Simple Interest is "+simpleInterest+" for Principal "+principal+", Rate of Interest "+rate+" and Time "+time);
		 
	}
}