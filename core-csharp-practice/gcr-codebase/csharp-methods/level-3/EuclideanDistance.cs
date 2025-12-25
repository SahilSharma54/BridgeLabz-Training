using System;

class EuclideanDistance{
	
	// Method to find Euclidean distance
	static double FindDistance(int x1,int y1,int x2,int y2){
		double distance=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
		return distance;
	}
	
	// Method to find slope and y-intercept
	static double[] FindLineEquation(int x1,int y1,int x2,int y2){
		double slope=(double)(y2-y1)/(x2-x1);
		double intercept=y1-slope*x1;
		return new double[]{slope,intercept};
	}
	
	static void Main(string[] args){
		
		// Taking input for first point
		int x1=int.Parse(Console.ReadLine());
		int y1=int.Parse(Console.ReadLine());
		
		// Taking input for second point
		int x2=int.Parse(Console.ReadLine());
		int y2=int.Parse(Console.ReadLine());
		
		// Calling distance method
		double distance=FindDistance(x1,y1,x2,y2);
		Console.WriteLine(distance);
		
		// Calling line equation method
		double[] result=FindLineEquation(x1,y1,x2,y2);
		Console.WriteLine("y="+result[0]+"*x+"+result[1]);
	}
}
