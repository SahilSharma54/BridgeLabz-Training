using System;

class HeapSort1
{
    static void Main()
    {
        // Ask number of job applicants
        Console.Write("Enter number of applicants: ");
        int totalApplicants = int.Parse(Console.ReadLine());

        // Array to store expected salaries
        int[] salaryArray = new int[totalApplicants];

        // Take salary input
        for (int index = 0; index < totalApplicants; index++)
        {
            Console.Write("Enter expected salary of applicant " + (index + 1) + ": ");
            salaryArray[index] = int.Parse(Console.ReadLine());
        }

        // Perform heap sort
        HeapSort(salaryArray, totalApplicants);

        // Display sorted salaries
        Console.WriteLine("Sorted Expected Salaries:");
        for (int index = 0; index < totalApplicants; index++)
        {
            Console.Write(salaryArray[index] + " ");
        }
    }

    // Heap Sort method
    static void HeapSort(int[] salaryArray, int size)
    {
        // Build max heap
        for (int index = size / 2 - 1; index >= 0; index--)
        {
            Heapify(salaryArray, size, index);
        }

        // Extract elements from heap
        for (int index = size - 1; index > 0; index--)
        {
            // Swap root with last element
            int temp = salaryArray[0];
            salaryArray[0] = salaryArray[index];
            salaryArray[index] = temp;

            // Heapify remaining heap
            Heapify(salaryArray, index, 0);
        }
    }

    // Heapify method
    static void Heapify(int[] salaryArray, int heapSize, int rootIndex)
    {
        int largestIndex = rootIndex;
        int leftChildIndex = 2 * rootIndex + 1;
        int rightChildIndex = 2 * rootIndex + 2;

        // Check left child
        if (leftChildIndex < heapSize && salaryArray[leftChildIndex] > salaryArray[largestIndex])
        {
            largestIndex = leftChildIndex;
        }

        // Check right child
        if (rightChildIndex < heapSize && salaryArray[rightChildIndex] > salaryArray[largestIndex])
        {
            largestIndex = rightChildIndex;
        }

        // Swap and continue heapifying if root is not largest
        if (largestIndex != rootIndex)
        {
            int temp = salaryArray[rootIndex];
            salaryArray[rootIndex] = salaryArray[largestIndex];
            salaryArray[largestIndex] = temp;

            Heapify(salaryArray, heapSize, largestIndex);
        }
    }
}
