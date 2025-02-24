using System;

class RecursionDemo
{
    // Recursive function to calculate factorial
    static int Factorial(int n)
    {
        if (n == 0) 
            return 1; // Base case
        else 
            return n * Factorial(n - 1); // Recursive call
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);
        Console.WriteLine($"Factorial of {num} is {result}");
    }
}
