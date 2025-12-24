using System;

class MultiDimensional{
	 static void Main(){
		
		// Taking user input for rows and columns
		int rows=int.Parse(Console.ReadLine());
		int columns=int.Parse(Console.ReadLine());
		
		// Creating a 2-d array
		int[,] matrix=new int[rows,columns];
		
		// Taking input for 2-d array element using nested for loop
		for(int iterator=0;iterator<rows;iterator++){
			for(int iterator2=0;iterator2<columns;iterator2++){
				matrix[iterator,iterator2]=int.Parse(Console.ReadLine());
			}
		}
		
		// Creating a 1-d array
		int[] array=new int[rows*columns];
		
		// Creating a variable for index;
		int index=0;
		
		// Transfering the elements from 2-d array to 1-d array
		for(int iterator=0;iterator<rows;iterator++){
			for(int iterator2=0;iterator2<columns;iterator2++){
				array[index]=matrix[iterator,iterator2];
				index++;
			}
		}
		
		// Displaying the results
		for(int iterator=0;iterator<array.Length;iterator++){
			Console.Write(array[iterator]+" ");
		}
		
	}
}