using System;

// Custom exception class
class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

class CustomExceptionDemo
{
    // Method to validate age
    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            // Call validation method
            ValidateAge(age);

            Console.WriteLine("Access granted!");
        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}
