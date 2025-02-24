using System;

class StringFunctionsDemo
{
    static void Main()
    {
        // 1. Compare() - Compares two strings and returns an integer (-1, 0, or 1)
        string str1 = "Hello";
        string str2 = "World";
        int result = string.Compare(str1, str2);
        Console.WriteLine($"Compare(\"{str1}\", \"{str2}\") = {result}");

        // 2. CompareTo() - Works similar to Compare() but used with instance of string
        result = str1.CompareTo(str2);
        Console.WriteLine($"\"{str1}\".CompareTo(\"{str2}\") = {result}");

        // 3. Concat() - Concatenates multiple strings
        string combined = string.Concat(str1, " ", str2, "!!!");
        Console.WriteLine($"Concat(\"{str1}\", \"{str2}\") = {combined}");

        // 4. Copy() - Creates a new copy of a string
        string strCopy = string.Copy(str1);
        Console.WriteLine($"Copy of \"{str1}\" = {strCopy}");

        // 5. Join() - Joins an array of strings using a separator
        string[] words = { "C#", "is", "awesome" };
        string joinedString = string.Join(" ", words);
        Console.WriteLine($"Join(\" \", [\"C#\", \"is\", \"awesome\"]) = {joinedString}");
    }
}
