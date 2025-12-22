using System;

class BonusOfEmployee{
	static void Main(String[] args){
		
		// Taking salary and year of service as input from the user
		int salary=int.Parse(Console.ReadLine());
		int yearOfService=int.Parse(Console.ReadLine());
		int bonus=0;
		
		// Checking if serivce is more than 5 years and providing them bonus
		if(yearOfService>5){
			bonus=(salary*5)/100;
		}
		
		// Displaying the Bonus Amount
		Console.WriteLine("The Bonus Amount is : "+bonus);
	}
}