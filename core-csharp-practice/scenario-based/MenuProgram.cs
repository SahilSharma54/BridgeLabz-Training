
/*

*Bus Route Distance Tracker 🚌
Each stop adds distance.
● Ask if the passenger wants to get off at a stop.
● Use a while-loop with a total distance tracker.
● Exit on user confirmation.

* Festival Lucky Draw 🎉
At Diwali mela, each visitor draws a number.
● If the number is divisible by 3 and 5, they win a gift.
● Use if, modulus, and loop for multiple visitors.
● continue if input is invalid.

*/

using System;

class SimpleMenuProgram{
	
    static void Main(){
		
        // Infinite loop for menu until user chooses to exit
        while (true){
			
            // Display menu options
            Console.WriteLine("\n===== Welcome to Fun Programs =====");
            Console.WriteLine("1. Bus Route Distance Tracker");
            Console.WriteLine("2. Festival Lucky Draw");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");

            string choice = Console.ReadLine(); // Read user input as string

            if (choice == "1"){
				
                BusRouteTracker(); // Call Bus Tracker function
            }
            else if (choice == "2"){
				
                FestivalLuckyDraw(); // Call Lucky Draw function
            }
            else if (choice == "3"){
				
                Console.WriteLine("Thank you for using the programs! Goodbye!");
                break; // Exit the menu loop
            }
            else{
				
                // If input is not 1,2,3
                Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
            }
        }
    }

    // Function for Bus Route Distance Tracker
    static void BusRouteTracker(){
		
        int totalDistance = 0; // Variable to store total distance
        string input = "";     // Variable to store yes/no response

        Console.WriteLine("\n--- Bus Route Distance Tracker ---");

        // Loop until passenger chooses to get off
        while (true){
			
            Console.Write("Enter distance to next stop (km): ");
            int distance = int.Parse(Console.ReadLine()); // Convert input to integer

            totalDistance += distance; // Add current distance to total
            Console.WriteLine("Total distance so far: " + totalDistance + " km");

            Console.Write("Do you want to get off at this stop? (yes/no): ");
            input = Console.ReadLine().ToLower(); // Convert input to lowercase

            if (input == "yes"){
				
                Console.WriteLine("You got off the bus. Total distance traveled: " + totalDistance + " km");
                break; // Exit the bus tracker loop
            }
            // If input is "no", loop continues to next stop
        }
    }

    // Function for Festival Lucky Draw
    static void FestivalLuckyDraw(){
		
        Console.WriteLine("\n--- Festival Lucky Draw ---");

        // Loop until user types "exit"
        while (true){
			
            Console.Write("Enter your lucky number (or type 'exit' to quit): ");
            string input = Console.ReadLine(); // Read input

            if (input.ToLower() == "exit"){
				
                Console.WriteLine("Exiting Lucky Draw. Thank you!");
                break; // Exit lucky draw loop
            }

            int number = int.Parse(input); // Convert input string to number

            // Check if number is divisible by 3 and 5
            if (number % 3 == 0 && number % 5 == 0){
				
                Console.WriteLine("Congratulations! You won a gift");
            }
            else{
				
                Console.WriteLine("Sorry, better luck next time.");
            }
        }
    }
}
