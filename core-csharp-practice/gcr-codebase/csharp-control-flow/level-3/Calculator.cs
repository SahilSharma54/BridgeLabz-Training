using System;

class Caculator{
	static void Main(String[] args){
		
		// Taking the values of first and second from the user and also variable for string op
		double first=double.Parse(Console.ReadLine());
		double second=double.Parse(Console.ReadLine());
		
		string op=Console.ReadLine();
		
		// Taking op as switch case variable 
		switch(op){
			case "+":
			Console.WriteLine("Output is : "+(first+second));
			break;
			
			case "-":
			Console.WriteLine("Output is : "+(first-second));
			break;
			
			case "*":
			Console.WriteLine("Output is : "+(first*second));
			break;
			
			case "/":
			Console.WriteLine("Output is : "+(first/second));
			break;
			
			default :
			Console.WriteLine("Invalid operator");
			break;
		}
		
		
	}
}