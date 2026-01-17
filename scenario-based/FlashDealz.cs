/*


FlashDealz – Product Sorting by Discount (Quick Sort)
Story: An e-commerce platform runs a flash sale with millions of products, each offering
different discounts. Users want to see the top discounted products instantly. To quickly sort
such large data, the backend uses Quick Sort, known for its fast average-case performance
and efficiency.
Concepts Involved:
● Quick Sort
● Large unsorted data
● Performance optimization.FitnessTracker – Daily Step Count Ranking (Bubble Sort)



*/

using System;

class FlashDealz
{
    static string[] productNames = new string[100];
    static int[] discounts = new int[100];
    static int count = 0;

    static void Main()
    {
        while (true)
        {
            ShowMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;

                case 2:
                    QuickSort(discounts, productNames, 0, count - 1);
                    DisplayProducts();
                    break;

                case 3:
                    Console.WriteLine("Exiting FlashDealz...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    // Menu display
    static void ShowMenu()
    {
        Console.WriteLine("\n--- FlashDealz ---");
        Console.WriteLine("1. Add Product");
        Console.WriteLine("2. Show Top Discounted Products");
        Console.WriteLine("3. Exit");
        Console.Write("Enter choice: ");
    }

    // Add product details
    static void AddProduct()
    {
        Console.Write("Enter product name: ");
        productNames[count] = Console.ReadLine();

        Console.Write("Enter discount percentage: ");
        discounts[count] = int.Parse(Console.ReadLine());

        count++;
        Console.WriteLine("Product added.");
    }

    // Quick Sort logic (descending order)
    static void QuickSort(int[] arr, string[] names, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, names, low, high);
            QuickSort(arr, names, low, pivotIndex - 1);
            QuickSort(arr, names, pivotIndex + 1, high);
        }
    }

    // Partition method
    static int Partition(int[] arr, string[] names, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j =low;j<high;j++)
        {
            if (arr[j] > pivot) // Higher discount first
            {
                i++;

                // Swap discounts
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

                // Swap product names
                string tempName = names[i];
                names[i] = names[j];
                names[j] = tempName;
            }
        }

        // Final pivot swap
        int tempPivot = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = tempPivot;

        string tempPivotName = names[i + 1];
        names[i + 1] = names[high];
        names[high] = tempPivotName;

        return i + 1;
    }

    // Display sorted products
    static void DisplayProducts()
    {
        Console.WriteLine("--- Top Discounted Products ---");
        for (int i=0;i<count;i++)
        {
            Console.WriteLine(productNames[i] + " - " + discounts[i] + "% OFF");
        }
    }
}
