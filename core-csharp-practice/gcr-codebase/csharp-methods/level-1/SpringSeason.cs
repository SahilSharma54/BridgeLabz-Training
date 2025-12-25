using System;

class SpringSeason{
    
    // Creating a method to check spring season
    static string CheckSpring(int month,int day){
        if((month==3&&day>=20)||(month==4)||(month==5)||(month==6&&day<=20)){
            return "Its a Spring Season";
        }
        else{
            return "Not a Spring Season";
        }
    }

    static void Main(string[] args){
        
        // Taking input for month and day
        int month=int.Parse(Console.ReadLine());
        int day=int.Parse(Console.ReadLine());
        
        // Displaying the result
        Console.WriteLine(CheckSpring(month,day));
    }
}
