using System;

class CollinearPoints{
	
	// Method to check collinearity using slope formula
	static bool CheckCollinearUsingSlope(int x1,int y1,int x2,int y2,int x3,int y3){
		double slopeAB=(double)(y2-y1)/(x2-x1);
		double slopeBC=(double)(y3-y2)/(x3-x2);
		double slopeAC=(double)(y3-y1)/(x3-x1);
		
		if(slopeAB==slopeBC&&slopeBC==slopeAC){
			return true;
		}
		else{
			return false;
		}
	}
	
	// Method to check collinearity using area of triangle
	static bool CheckCollinearUsingArea(int x1,int y1,int x2,int y2,int x3,int y3){
		double area=0.5*(x1*(y2-y3)+x2*(y3-y1)+x3*(y1-y2));
		
		if(area==0){
			return true;
		}
		else{
			return false;
		}
	}
	
	static void Main(string[] args){
		
		// Taking input for point A
		int x1=int.Parse(Console.ReadLine());
		int y1=int.Parse(Console.ReadLine());
		
		// Taking input for point B
		int x2=int.Parse(Console.ReadLine());
		int y2=int.Parse(Console.ReadLine());
		
		// Taking input for point C
		int x3=int.Parse(Console.ReadLine());
		int y3=int.Parse(Console.ReadLine());
		
		// Checking using slope method
		bool slopeResult=CheckCollinearUsingSlope(x1,y1,x2,y2,x3,y3);
		Console.WriteLine(slopeResult);
		
		// Checking using area method
		bool areaResult=CheckCollinearUsingArea(x1,y1,x2,y2,x3,y3);
		Console.WriteLine(areaResult);
	}
}
