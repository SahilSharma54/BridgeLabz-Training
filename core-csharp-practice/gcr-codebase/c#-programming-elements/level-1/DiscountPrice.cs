using System;

class DiscountPrice{
	static void Main(String[] args){
		
		// Creating variables for storing fee, discount percent, discount
		int fee=125000;
		float discountPercent=10f;
		
		// calculating discount
		float discount=(discountPercent/100)*fee;
		
		// Displaying result
		Console.WriteLine("The discount amount is INR "+discount+" and the final discounted fee is INR "+(fee-discount));
		
		
	}
}