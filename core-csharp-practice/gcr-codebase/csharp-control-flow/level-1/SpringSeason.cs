using System;

class SpringSeason{
	static void Main(String[] args){
		
		// Get the input value from the user for month and day
		int month=int.Parse(Console.ReadLine());
		int day=int.Parse(Console.ReadLine());
		
		// Condition for checking the season and displaying the result
		if((month==3&&day>=20)||(month==4)||(month==5)){
			Console.WriteLine("Its a Spring Season");
		}
		else if(month==6&&day<=20){
			Console.WriteLine("Its a Spring Season");
		}
		else{
			Console.WriteLine("Not a Spring Season");
		}
		
    }
}