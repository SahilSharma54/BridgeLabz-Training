using System;
class Operators{
	static void Main(String[] args){
		Console.WriteLine("Using the Operators of various types");
		int numberOne=5;
		Console.WriteLine("Number 1 is : 5");
		int numberTwo=10;
		Console.WriteLine("number 2 is : 10");
		
		Console.WriteLine("Arithmatic Operators ");
		
		Console.WriteLine("Addition");
		int addition=numberOne+numberTwo;
		Console.WriteLine(addition);
		
		Console.WriteLine("Subtraction");
		int subtraction=numberOne-numberTwo;
		Console.WriteLine(subtraction);
		
		Console.WriteLine("Multiplication");
		int multiply=numberOne*numberTwo;
		Console.WriteLine(multiply);
		
		Console.WriteLine("Division");
		int divide=numberOne/numberTwo;
		Console.WriteLine(divide);
		
		Console.WriteLine("Modulus");
		int modulus=numberOne%numberTwo;
		Console.WriteLine(modulus);
		
		
		
		Console.WriteLine("Relational Operators");
		
		Console.WriteLine("Equal to");
		Console.WriteLine(numberOne==numberTwo);
		
		Console.WriteLine("Not Equal to");
		Console.WriteLine(numberOne!=numberTwo);
		
		Console.WriteLine("Greater than");
		Console.WriteLine(numberOne>numberTwo);
		
		Console.WriteLine("Less than");
		Console.WriteLine(numberOne<numberTwo);
		
		Console.WriteLine("Greater than or equal to");
		Console.WriteLine(numberOne>=numberTwo);
		
		Console.WriteLine("Less than or equal to");
		Console.WriteLine(numberOne<=numberTwo);
		
		
		Console.WriteLine("Logical Operators");
		
		Console.WriteLine("Taking new Variables var1 : true and var2 : false");
		bool var1=true;
		bool var2=false;
		
		Console.WriteLine("Logical AND");
		Console.WriteLine(var1&&var2);
		
		Console.WriteLine("Logical OR");
		Console.WriteLine(var1||var2);
		
		Console.WriteLine("Logical NOT");
		Console.WriteLine(!var1);
		
		
		Console.WriteLine("Assignment operator");
		
		Console.WriteLine("Assignment");
		numberOne=numberTwo;
		Console.WriteLine(numberOne);
		
		Console.WriteLine("Addition Assignment");
		numberOne+=numberTwo;
		Console.WriteLine(numberOne);
		
		Console.WriteLine("Subtraction Assignment");
		numberOne-=numberTwo;
		Console.WriteLine(numberOne);
		
		Console.WriteLine("Multiplication Assignment");
		numberOne*=numberTwo;
		Console.WriteLine(numberOne);
		
		Console.WriteLine("Division Assignment");
		numberOne/=numberTwo;
		Console.WriteLine(numberOne);
		
		Console.WriteLine("Modulus Assignment");
		numberOne%=numberTwo;
		Console.WriteLine(numberOne);
		
		
		Console.WriteLine("Unary Operators");
		
		Console.WriteLine("Taking number as : 2");
		int number1=2;
		
		Console.WriteLine("Increment");
		Console.WriteLine(++number1);
		
		Console.WriteLine("Decrement");
		Console.WriteLine(--number1);
		
		
		
		Console.WriteLine("Ternary Operator");
		numberOne=10;
		numberTwo=20;
		int min=numberOne<numberTwo?numberOne:numberTwo;
		Console.WriteLine(min);
		
		
		Console.WriteLine("is Operator");
		Console.WriteLine(numberOne is Operators);
		
	}
}