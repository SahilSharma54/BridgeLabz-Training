using System;

// Interface for Meal Plan
interface IMealPlan
{
    void GeneratePlan();
}

// Vegetarian Meal
class VegetarianMeal : IMealPlan
{
    public void GeneratePlan()
    {
        Console.WriteLine("Vegetarian Meal Plan:");
        Console.WriteLine("- Paneer");
        Console.WriteLine("- Vegetables");
        Console.WriteLine("- Roti");
    }
}

// Vegan Meal
class VeganMeal : IMealPlan
{
    public void GeneratePlan()
    {
        Console.WriteLine("Vegan Meal Plan:");
        Console.WriteLine("- Tofu");
        Console.WriteLine("- Salad");
        Console.WriteLine("- Fruits");
    }
}

// Keto Meal
class KetoMeal : IMealPlan
{
    public void GeneratePlan()
    {
        Console.WriteLine("Keto Meal Plan:");
        Console.WriteLine("- Eggs");
        Console.WriteLine("- Cheese");
        Console.WriteLine("- Nuts");
    }
}

// Generic Meal class with constraint
class Meal<T> where T : IMealPlan, new()
{
    // Generic method to generate meal plan
    public void CreateMealPlan()
    {
        T meal = new T();     // object created dynamically
        meal.GeneratePlan();
    }
}

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("--- Personalized Meal Plan Menu ---");
            Console.WriteLine("1. Vegetarian Meal");
            Console.WriteLine("2. Vegan Meal");
            Console.WriteLine("3. Keto Meal");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new Meal<VegetarianMeal>().CreateMealPlan();
                    break;

                case 2:
                    new Meal<VeganMeal>().CreateMealPlan();
                    break;

                case 3:
                    new Meal<KetoMeal>().CreateMealPlan();
                    break;
            }

        } while (choice != 4);
    }
}
