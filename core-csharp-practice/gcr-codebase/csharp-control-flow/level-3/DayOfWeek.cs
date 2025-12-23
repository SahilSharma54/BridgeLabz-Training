using System;

class DayOfWeek{
	static void Main(String[] args){
		
		// Taking the values for months, days, years from the user
		int month=int.Parse(Console.ReadLine());
		int day=int.Parse(Console.ReadLine());
		int year=int.Parse(Console.ReadLine());
		
		// Calculation by putting the values in the given equation in the variables also
		
		int y0=year-(14-month)/12;
		int x=y0+y0/4-y0/100+y0/400;
		int m0=month+12*((14-month)/12)-2;
		int d0=(day+x+(31*m0)/12)%7;
		
		// Displaying the result
		Console.WriteLine("Day of the week 0=sunday, 1=monday, 2=tuesday, 3=wednesday, 4=thrusday, 5=friday, 6=saturday");
		Console.WriteLine("Here is your output : "+d0);
	}
}