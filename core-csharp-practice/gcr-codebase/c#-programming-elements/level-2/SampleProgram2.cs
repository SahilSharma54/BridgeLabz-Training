using System;

class SampleProgram2{
	static void Main(String[] args){
		
		// Creating a variable name to indicate the person traveling
      string name =Console.ReadLine();
      
      // Create variables fromCity ,  viaCity , and  toCity  for the cities
      string fromCity = Console.ReadLine();
	  string viaCity = Console.ReadLine();
	  string toCity = Console.ReadLine();

      // Create variables for distances and times
      double distanceFromToVia = 156.6;
      int timeFromToVia = 4 * 60 + 4; // Time in minutes
      double distanceViaToFinalCity = 211.8;
      int timeViaToFinalCity = 4 * 60 + 25; // Time in minutes

      // Compute the total distance and total time
      double totalDistance = distanceFromToVia + distanceViaToFinalCity;
      int totalTime = timeFromToVia + timeViaToFinalCity;

      // Print the travel details
      Console.WriteLine("The Total Distance travelled by "+name+" from "+fromCity+" to "+toCity+" via "+viaCity+" is "+totalDistance+" km and the Total Time taken is "+totalTime+" minutes");

		
	}
}