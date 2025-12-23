using System;

class YoungestFriends{
	static void Main(String[] args){
		
		// Taking the values of age of the three friends
		int ageOfAmar=int.Parse(Console.ReadLine());
		int ageOfAkbar=int.Parse(Console.ReadLine());
		int ageOfAnthony=int.Parse(Console.ReadLine());
		
		// Taking variable for youngest friend and tallest friend
		int tallest=0;
		int smallest=0;
		
		// Finding the smallest friend
		if(ageOfAkbar<ageOfAmar&&ageOfAkbar<ageOfAnthony){
			smallest=ageOfAkbar;
		}
		else if(ageOfAmar<ageOfAkbar&&ageOfAmar<ageOfAnthony){
			smallest=ageOfAmar;
		}
		else if(ageOfAnthony<ageOfAmar&&ageOfAnthony<ageOfAmar){
			smallest=ageOfAnthony;
		}
		
		// Finding the tallest friend
		if(ageOfAkbar>ageOfAmar && ageOfAkbar>ageOfAnthony){
			tallest=ageOfAkbar;
		}
		else if(ageOfAmar>ageOfAkbar && ageOfAmar>ageOfAnthony){
			tallest=ageOfAmar;
		}
		else if(ageOfAnthony>ageOfAmar&&ageOfAnthony>ageOfAmar){
			tallest=ageOfAnthony;
		}
		
		// Displaying the result
		Console.WriteLine("Youngest age is : "+smallest);
		Console.WriteLine("Tallest age is : "+tallest);
	}
}