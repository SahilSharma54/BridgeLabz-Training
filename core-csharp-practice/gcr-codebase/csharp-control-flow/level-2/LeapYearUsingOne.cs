using System;

class LeapYearUsingOne{
	static void Main(String[] args){
		
		// Taking year as input from the user
		int year=int.Parse(Console.ReadLine());
		
		// Checking the condition for a leap year if satified or not and displaying the results
			if((year%4==0 && year%100!=0)&& year>=1582||(year%400==0)&& year>=1582){
				Console.WriteLine("The year is : "+year+" is leap year");
			}
			else{
				Console.WriteLine("The year is : "+year+" is not a leap year");
			}
		
		
	}
		
}