using System;

class CalculatePercentage{
	
 static void Main(String[] args){
	 
	 // Taking the input marks of the three subjects from the user
	 int marksPhysics=int.Parse(Console.ReadLine());
	 int marksChemistry=int.Parse(Console.ReadLine());
	 int marksMaths=int.Parse(Console.ReadLine());
	 
	 // Taking a new variable percentage
	 int percentage=0;
	 
	 
	 // Computing the percentages
	percentage=(marksPhysics+marksChemistry+marksMaths)*100/300;
	
	
	// Allocating if conditions according to the scenario given with displaying the results also
	if(percentage>=80){
		Console.WriteLine("Your Marks percentage is : "+percentage+" with grade "+" A ");
	}
	else if(percentage>=70&&percentage<=79){
		Console.WriteLine("Your Marks percentage is : "+percentage+" with grade "+" B ");
	}
	else if(percentage>=60&&percentage<=69){
		Console.WriteLine("Your Marks percentage is : "+percentage+" with grade "+" C ");
	}
	else if(percentage>=50&&percentage<=59){
		Console.WriteLine("Your Marks percentage is : "+percentage+" with grade "+" D ");
	}
	else if(percentage>=40&&percentage<=49){
		Console.WriteLine("Your Marks percentage is : "+percentage+" with grade "+" E ");
	}
	else{
		Console.WriteLine("Your Marks percentage is : "+percentage+" with grade "+" R ");
	}

 }
	
}