using System;

class TotalPrice{
	static void Main(String[] args){
		
		// Creating variables to store unitprice and quantity
		int unitPrice=int.Parse(Console.ReadLine());
		int quantity=int.Parse(Console.ReadLine());
		
		// Calculating Total Price 
		int totalPrice=unitPrice*quantity;
		
		// Displaying the results
		Console.WriteLine("The total purchase price is INR "+totalPrice+"if the quantity "+quantity+" and the unit price is INR "+unitPrice);
	}
}