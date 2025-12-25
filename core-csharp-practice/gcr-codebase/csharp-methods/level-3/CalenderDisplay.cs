using System;

class CalendarDisplay{
	
	// Method to get month name
	static string GetMonthName(int month){
		string[] monthNames={"January","February","March","April","May","June","July","August","September","October","November","December"};
		return monthNames[month-1];
	}
	
	// Method to check leap year
	static bool IsLeapYear(int year){
		if(year%400==0){
			return true;
		}
		else if(year%100==0){
			return false;
		}
		else if(year%4==0){
			return true;
		}
		else{
			return false;
		}
	}
	
	// Method to get number of days in a month
	static int GetNumberOfDays(int month,int year){
		int[] daysInMonth={31,28,31,30,31,30,31,31,30,31,30,31};
		
		if(month==2&&IsLeapYear(year)){
			return 29;
		}
		else{
			return daysInMonth[month-1];
		}
	}
	
	// Method to get first day of the month
	static int GetFirstDay(int month,int year){
		int y0=year-(14-month)/12;
		int x=y0+y0/4-y0/100+y0/400;
		int m0=month+12*((14-month)/12)-2;
		int d0=(1+x+(31*m0)/12)%7;
		return d0;
	}
	
	static void Main(string[] args){
		
		// Taking month input
		int month=int.Parse(Console.ReadLine());
		
		// Taking year input
		int year=int.Parse(Console.ReadLine());
		
		// Displaying month and year
		Console.WriteLine(GetMonthName(month)+" "+year);
		
		// Displaying days header
		Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
		
		int firstDay=GetFirstDay(month,year);
		int numberOfDays=GetNumberOfDays(month,year);
		
		// Printing spaces for first day
		for(int space=0;space<firstDay;space++){
			Console.Write("    ");
		}
		
		// Printing days of the month
		for(int day=1;day<=numberOfDays;day++){
			Console.Write(string.Format("{0,3} ",day));
			
			if((day+firstDay)%7==0){
				Console.WriteLine();
			}
		}
	}
}
