using System;

class NestedTryCatch
{
    static void Main()
    {
        try
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            // Take array elements
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            try
            {
                // Try to access array index
                int value = arr[index];

                try
                {
                    // Try division
                    int result = value / divisor;
                    Console.WriteLine("Result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numbers");
        }
    }
}
