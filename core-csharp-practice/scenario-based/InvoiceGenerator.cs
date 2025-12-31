
/*

Invoice Generator for Freelancers
Focus: Strings, Methods
● Scenario: You're building an app for freelancers to generate invoice descriptions.
 Requirements:
● Accept input like: "Logo Design - 3000 INR, Web Page - 4500 INR".
● Split the string to extract task names and amounts.
● Calculate total invoice amount.
● Example Methods:
● ParseInvoice(string input)
● GetTotalAmount(string[] tasks)

*/

using System;

class InvoiceGenerator{

    // Method to calculate total amount
    static int GetTotalAmount(string input){
        int total = 0;
        int number = 0;

        for(int i = 0; i < input.Length; i++){

            // Check if character is a number
            if(input[i] >= '0' && input[i] <= '9'){
                number = number * 10 + (input[i] - '0');
            }
            else{
                // When number ends, add to total
                if(number > 0){
                    total = total + number;
                    number = 0;
                }
            }
        }

        // Add last number if exists
        if(number > 0){
            total = total + number;
        }

        return total;
    }

    // Method to display tasks
    static void DisplayTasks(string input){
        Console.WriteLine("\nInvoice Items:");

        string word = "";

        for(int i = 0; i < input.Length; i++){
            if(input[i] == ','){
                Console.WriteLine(word);
                word = "";
            }
            else{
                word = word + input[i];
            }
        }

        Console.WriteLine(word);
    }

    static void Main(string[] args){

        Console.WriteLine("Enter invoice details:");
        Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR");

        string input = Console.ReadLine();

        DisplayTasks(input);

        int total = GetTotalAmount(input);

        Console.WriteLine("\nTotal Invoice Amount: " + total + " INR");
    }
}
