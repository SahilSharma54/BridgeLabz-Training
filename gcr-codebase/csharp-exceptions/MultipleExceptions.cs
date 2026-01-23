using System;

class MultipleExceptions
{
    static void Main()
    {
        try
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            // Create integer array
            int[] arr = new int[size];

            // Take array elements from user
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter index to retrieve value: ");
            int index = int.Parse(Console.ReadLine());

            // Access array element
            Console.WriteLine("Value at index " + index + ": " + arr[index]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}
