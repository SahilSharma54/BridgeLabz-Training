
/*

Cafeteria Menu App
Focus: Arrays, Methods
● Scenario: The campus cafeteria offers 10 fixed items daily. You need to build a system to display menu items and take orders based on user input.
● Requirements:
● Store items in a string[] array.
● Print the menu with index numbers.
● Allow the user to select an item by index.
● Use methods like DisplayMenu(), GetItemByIndex().

*/

using System;

class CafeteriaMenuApp{
	
    static void Main(){
		
        // Array to store 10 food items
        string[] menuItems = {"Burger","Pizza","Sandwich","Pasta","Noodles","Fried Rice","Coffee","Tea","Juice","Ice Cream"};

        // Display menu
        DisplayMenu(menuItems);

        // Ask user to choose an item
        Console.Write("\nEnter the item number you want to order: ");
        int choice = int.Parse(Console.ReadLine());

        // Get selected item using method
        string selectedItem = GetItemByIndex(menuItems, choice);

        // Display result
        if (selectedItem != ""){
			
            Console.WriteLine("You selected: " + selectedItem);
        }
        else{
			
            Console.WriteLine("Invalid selection!");
        }
    }

    // Method to display menu items
    static void DisplayMenu(string[] items){
		
        Console.WriteLine("----- Cafeteria Menu -----");

        for (int i = 0; i < items.Length; i++){
			
            // Display item number and name
            Console.WriteLine(i + " - " + items[i]);
        }
    }

    // Method to return item based on index
    static string GetItemByIndex(string[] items, int index){
        // Check if index is valid
        if (index >= 0 && index < items.Length)
        {
            return items[index];
        }
        else
        {
            return "";
        }
    }
}
