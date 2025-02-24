using System;

class ArrayDemo
{
    static void Main()
    {
        // One-Dimensional Array
        int[] numbers = new int[5]; // Declaring a 1D array
        Console.WriteLine("Enter 5 numbers for 1D array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("1D Array elements:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n"); // New line for separation

        // Two-Dimensional Array
        int[,] matrix = new int[3, 3]; // Declaring a 2D array (3x3 matrix)
        Console.WriteLine("Enter 9 elements for the 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("2D Matrix elements:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine(); // Move to the next row
        }
    }
}
