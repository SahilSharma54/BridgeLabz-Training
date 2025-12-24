using System;

class FactorsOfNumbers{
	static void Main(String[] args){
		
		// Taking the input of number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a variable for index, maxFactor;
		int maxFactor=10;
		int index=0;
		
		// Creating a array for storing the factors
		int[] factorsOfNumber=new int[maxFactor];
		
		// Find factors from 1 to the number using for loop
		for(int iterator=1;iterator<=number;iterator++){
			if(number%iterator==0){
				
				// if index is same as the maxFactor
				if(index==maxFactor){
					maxFactor=maxFactor*2;
					int[] temporary=new int[maxFactor]; 
					
					// copying element
					for(int iterator2=0;iterator2<index;iterator2++){
						temporary[iterator2]=factorsOfNumber[iterator2];
					}
					
					factorsOfNumber=temporary;
				}
				
				factorsOfNumber[index]=iterator;
				index++;
			}
		
	    }
		// Displaying the results
		for(int iterator3=0;iterator3<index;iterator3++){
			Console.WriteLine(factorsOfNumber[iterator3]);
		}
    }
}