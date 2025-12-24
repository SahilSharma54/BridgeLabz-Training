using System;

class SecondLargest{
	
	static void Main(String[] args){
		
		int userLimit=int.Parse(Console.ReadLine());
		int[] arr=new int[userLimit];
		for(int i=0;i<arr.Length;i++){
			arr[i]=int.Parse(Console.ReadLine()); 
		}
		int secondLargest=0;
		
		for(int j=0;j<arr.Length-1;j++){
		   for(int k=0;k<arr.Length-j-1;k++){
			if(arr[j]>arr[j+1]){
				int temp = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = temp;
			}
		  }
		}
		secondLargest=arr[arr.Length-2];
		Console.WriteLine("Second Largest Element is : "+secondLargest);
	}

}