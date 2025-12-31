/*

 You are tasked with creating a utility class for mathematical operations.
Implement the following functionalities using separate methods:
● A method to calculate the factorial of a number.
● A method to check if a number is prime.
● A method to find the greatest common divisor (GCD) of two numbers.
● A method to find the nth Fibonacci number.
● Test your methods with various inputs, including edge cases like zero, one, and
negative numbers.

*/



using System;

class MathUtility{

    // Method to find factorial
    static long Factorial(int number){

        if (number < 0){
            Console.WriteLine("Factorial not possible for negative numbers.");
            return -1;
        }

        long result = 1;

        for (int i = 1; i <= number; i++){
            result = result * i;
        }

        return result;
    }

    // Method to check prime number
    static bool IsPrime(int number){

        if (number <= 1)
            return false;

        for (int i = 2; i <= number / 2; i++){
            if (number % i == 0)
                return false;
        }

        return true;
    }

    // Method to find GCD
    static int FindGCD(int a, int b){

        if (a < 0) a = -a;
        if (b < 0) b = -b;

        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    // Method to find Fibonacci number
    static int Fibonacci(int n){

        if (n < 0){
            Console.WriteLine("Fibonacci not possible for negative numbers.");
            return -1;
        }

        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        int a = 0, b = 1, c = 0;

        for (int i = 2; i <= n; i++){
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }

    static void Main(string[] args){

        int choice;

        do{
            Console.WriteLine("--- Math Utility Menu ---");
            Console.WriteLine("1. Factorial");
            Console.WriteLine("2. Prime Check");
            Console.WriteLine("3. GCD");
            Console.WriteLine("4. Fibonacci");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch(choice){

                case 1:
                    Console.Write("Enter number: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Factorial = " + Factorial(num));
                    break;

                case 2:
                    Console.Write("Enter number: ");
                    int num2 = int.Parse(Console.ReadLine());

                    if (IsPrime(num2))
                        Console.WriteLine("Number is Prime");
                    else
                        Console.WriteLine("Number is Not Prime");
                    break;

                case 3:
                    Console.Write("Enter first number: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    int b = int.Parse(Console.ReadLine());

                    Console.WriteLine("GCD = " + FindGCD(a, b));
                    break;   

                case 4:
                    Console.Write("Enter n value: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Fibonacci = " + Fibonacci(n));
                    break;

                case 5:
                    Console.WriteLine("Program Ended.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}
