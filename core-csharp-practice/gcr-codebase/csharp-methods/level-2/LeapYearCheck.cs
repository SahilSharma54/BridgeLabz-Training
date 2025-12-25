using System;

class LeapYearCheck{
    static bool IsLeapYear(int year){
        if(year>=1582&&((year%4==0&&year%100!=0)||year%400==0)){
            return true;
        }
        return false;
    }

    static void Main(string[] args){
        int year=int.Parse(Console.ReadLine());

        if(IsLeapYear(year)){
            Console.WriteLine("Leap Year");
        }
		else{
            Console.WriteLine("Not Leap Year");
        }
    }
}
