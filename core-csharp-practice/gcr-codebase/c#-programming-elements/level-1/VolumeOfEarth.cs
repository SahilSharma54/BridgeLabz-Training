using System;

class VolumeOfEarth{
	static void Main(String[] args){
		
		// Creating variables for storing values of pi, radius
		double pi=3.14f;
		double radiusKm=6378f;
		
		// Creating variable radiusMiles for sorting km to miles
		double radiusMiles=radiusKm*0.621371f;
		
		// Creating variables for volumeKm and volumeM
		double volumeKm=(4.0/3.0)*pi*(radiusKm*radiusKm*radiusKm);
		double volumeM=(4.0/3.0)*pi*(radiusMiles*radiusMiles*radiusMiles);
		
		// Displaying the results
		Console.WriteLine("The Volume of earth in cubic kilometers is "+volumeKm+" and cubic miles is "+volumeM);
		
	}
}