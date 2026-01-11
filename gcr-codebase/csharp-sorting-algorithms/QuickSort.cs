using System;

class QuickSort1
{
    static void Main()
    {
        // Ask number of products
        Console.Write("Enter number of products: ");
        int totalProducts = int.Parse(Console.ReadLine());

        // Array to store product prices
        int[] productPrices = new int[totalProducts];

        // Taking product price input
        for (int index = 0; index < totalProducts; index++)
        {
            Console.Write("Enter price of product " + (index + 1) + ": ");
            productPrices[index] = int.Parse(Console.ReadLine());
        }

        // Call quick sort
        QuickSort(productPrices, 0, totalProducts - 1);

        // Display sorted prices
        Console.WriteLine("Sorted Product Prices:");
        for (int index = 0; index < totalProducts; index++)
        {
            Console.Write(productPrices[index] + " ");
        }
    }

    // Quick sort method
    static void QuickSort(int[] pricesArray, int lowIndex, int highIndex)
    {
        if (lowIndex < highIndex)
        {
            int pivotPosition = Partition(pricesArray, lowIndex, highIndex);
            QuickSort(pricesArray, lowIndex, pivotPosition - 1);
            QuickSort(pricesArray, pivotPosition + 1, highIndex);
        }
    }

    // Partition method
    static int Partition(int[] pricesArray, int lowIndex, int highIndex)
    {
        int pivotValue = pricesArray[highIndex];
        int smallerIndex = lowIndex - 1;

        for (int currentIndex = lowIndex; currentIndex < highIndex; currentIndex++)
        {
            if (pricesArray[currentIndex] < pivotValue)
            {
                smallerIndex++;

                int temp = pricesArray[smallerIndex];
                pricesArray[smallerIndex] = pricesArray[currentIndex];
                pricesArray[currentIndex] = temp;
            }
        }

        int swapTemp = pricesArray[smallerIndex + 1];
        pricesArray[smallerIndex + 1] = pricesArray[highIndex];
        pricesArray[highIndex] = swapTemp;

        return smallerIndex + 1;
    }
}
