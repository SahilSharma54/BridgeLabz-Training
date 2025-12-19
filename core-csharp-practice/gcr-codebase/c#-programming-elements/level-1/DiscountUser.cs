using System;

class DiscountUser{
	static void Main(String[] args){
		
		// Creating variables for storing fee, discount percent, discount
		int fee=int.Parse(Console.ReadLine());
		float discountPercent=float.Parse(Console.ReadLine());
		
		// calculating discount
		float discount=(discountPercent/100)*fee;
		
		// Displaying result
		Console.WriteLine("The discount amount is INR "+discount+" and the final discounted fee is INR "+(fee-discount));
		
		
	}
}