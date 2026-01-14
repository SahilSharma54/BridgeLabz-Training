using System;
using System.Diagnostics;

class SortingComparison
{
    static void Main()
    {
        int size = 10000;
        int[] data = new int[size];

        Random random = new Random();

        // Fill array with random numbers
        for (int i = 0; i < size; i++)
        {
            data[i] = random.Next(1, 100000);
        }

        Stopwatch watch = new Stopwatch();

        // Bubble Sort 
        int[] bubbleArray = CopyArray(data);
        watch.Start();
        BubbleSort(bubbleArray);
        watch.Stop();
        Console.WriteLine("Bubble Sort Time: " + watch.ElapsedMilliseconds + " ms");

        watch.Reset();

        // Merge Sort 
        int[] mergeArray = CopyArray(data);
        watch.Start();
        MergeSort(mergeArray, 0, mergeArray.Length - 1);
        watch.Stop();
        Console.WriteLine("Merge Sort Time: " + watch.ElapsedMilliseconds + " ms");

        watch.Reset();

        // Quick Sort 
        int[] quickArray = CopyArray(data);
        watch.Start();
        QuickSort(quickArray, 0, quickArray.Length - 1);
        watch.Stop();
        Console.WriteLine("Quick Sort Time: " + watch.ElapsedMilliseconds + " ms");
    }
	

    // Method to copy array 
    static int[] CopyArray(int[] source)
    {
        int[] copy = new int[source.Length];

        for (int i = 0; i < source.Length; i++)
        {
            copy[i] = source[i];
        }

        return copy;
    }

    //  Bubble Sort 
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort 
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int size = right - left + 1;
        int[] temp = new int[size];

        int i = left;
        int j = mid + 1;
        int k = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] < arr[j])
            {
                temp[k++] = arr[i++];
            }
            else
            {
                temp[k++] = arr[j++];
            }
        }

        while (i <= mid)
        {
            temp[k++] = arr[i++];
        }

        while (j <= right)
        {
            temp[k++] = arr[j++];
        }

        for (i = left, k = 0; i <= right; i++, k++)
        {
            arr[i] = temp[k];
        }
    }

    // Quick Sort 
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;

        return i + 1;
    }
}
