using System;

class TotalIncome{
	static void Main(String[] args){
		
		// Creating variables to store the values of salary, bonus from the user
		int salary=int.Parse(Console.ReadLine());
		int bonus=int.Parse(Console.ReadLine());
		
		// Calculation of the income 
		int income=salary+bonus;
		
		// Displaying the Results
		Console.WriteLine("The salary is INR "+salary+" and bonus is INR "+bonus+" .Hence Total Income is INR "+income);
		
	}
}