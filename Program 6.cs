using System;

class ArraySorting
{
    static void Main()
    {
        int[] numbers = { 10, 5, 8, 3, 7, 2, 9, 1, 6, 4 }; // Array with 10 elements

        Array.Sort(numbers); // Sorting the array in ascending order

        Console.WriteLine("Array elements in increasing order:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
