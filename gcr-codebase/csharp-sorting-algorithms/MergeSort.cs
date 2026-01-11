using System;

class MergeSort1
{
    static void Main()
    {
        // Ask number of books
        Console.Write("Enter number of books: ");
        int totalBooks = int.Parse(Console.ReadLine());

        // Array to store book prices
        int[] bookPrices = new int[totalBooks];

        // Taking book price input
        for (int index = 0; index < totalBooks; index++)
        {
            Console.Write("Enter price of book " + (index + 1) + ": ");
            bookPrices[index] = int.Parse(Console.ReadLine());
        }

        // Call merge sort
        MergeSort(bookPrices, 0, totalBooks - 1);

        // Display sorted prices
        Console.WriteLine("Sorted Book Prices:");
        for (int index = 0; index < totalBooks; index++)
        {
            Console.Write(bookPrices[index] + " ");
        }
    }

    // Method to divide the array
    static void MergeSort(int[] pricesArray, int leftIndex, int rightIndex)
    {
        if (leftIndex < rightIndex)
        {
            int middleIndex = (leftIndex + rightIndex) / 2;

            MergeSort(pricesArray, leftIndex, middleIndex);
            MergeSort(pricesArray, middleIndex + 1, rightIndex);
            Merge(pricesArray, leftIndex, middleIndex, rightIndex);
        }
    }

    // Method to merge two sorted parts
    static void Merge(int[] pricesArray, int leftIndex, int middleIndex, int rightIndex)
    {
        int leftSize = middleIndex - leftIndex + 1;
        int rightSize = rightIndex - middleIndex;

        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        for (int i = 0; i < leftSize; i++)
            leftArray[i] = pricesArray[leftIndex + i];

        for (int j = 0; j < rightSize; j++)
            rightArray[j] = pricesArray[middleIndex + 1 + j];

        int leftPointer = 0, rightPointer = 0, mainPointer = leftIndex;

        while (leftPointer < leftSize && rightPointer < rightSize)
        {
            if (leftArray[leftPointer] <= rightArray[rightPointer])
            {
                pricesArray[mainPointer] = leftArray[leftPointer];
                leftPointer++;
            }
            else
            {
                pricesArray[mainPointer] = rightArray[rightPointer];
                rightPointer++;
            }
            mainPointer++;
        }

        while (leftPointer < leftSize)
        {
            pricesArray[mainPointer] = leftArray[leftPointer];
            leftPointer++;
            mainPointer++;
        }

        while (rightPointer < rightSize)
        {
            pricesArray[mainPointer] = rightArray[rightPointer];
            rightPointer++;
            mainPointer++;
        }
    }
}
