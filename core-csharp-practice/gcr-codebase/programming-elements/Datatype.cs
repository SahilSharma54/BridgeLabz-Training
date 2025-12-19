using System;

class Datatype{
	static void Main(String[] args){
		
		Console.WriteLine("Showing the Primitive Datatypes");
		Console.WriteLine("int Datatype - stores whole numbers");
		int number=19;
		Console.WriteLine(number);
		
		Console.WriteLine("float Datatype - stores decimal numbers");
		float percent=20.8f;
		Console.WriteLine(percent);
		
		Console.WriteLine("double Datatype - stores decimal numbers with double precision");
		double deci=23.999038;
		Console.WriteLine(deci);
		
		Console.WriteLine("char Datatype - stores a single character");
		char letter='z';
		Console.WriteLine(letter);
		
		Console.WriteLine("bool Datatype - stores true and false");
		bool condition=true;
		Console.WriteLine(condition);
		
		
		
		Console.WriteLine("Type Conversions");
		
		Console.WriteLine("Implicit Conversion value : 10");
		int number1=10;
		double number2=number1;
		Console.WriteLine(number2);
		
		Console.WriteLine("Explicit Conversion value : 12.5");
		double number3=12.5;
		int number4=(int)number3;
		Console.WriteLine(number4);
		
		
		
		
	} 
}