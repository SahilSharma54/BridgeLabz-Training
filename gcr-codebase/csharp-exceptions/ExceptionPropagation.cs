using System;

class ExceptionPropagation
{
    // Method 1 throws exception
    static void Method1(int a, int b)
    {
        // This may cause ArithmeticException
        int result = a / b;
        Console.WriteLine("Result: " + result);
    }

    // Method 2 calls Method1
    static void Method2(int a, int b)
    {
        Method1(a, b);
    }

    static void Main()
    {
        // Take input from user
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        try
        {
            // Call Method2
            Method2(a, b);
        }
        catch (ArithmeticException)
        {
            // Exception handled in Main
            Console.WriteLine("Handled exception in Main (Division by zero)");
        }
    }
}
