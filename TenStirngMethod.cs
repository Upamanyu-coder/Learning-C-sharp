using System;

public class StringMethodsDemo
{
    public static void Main()
    {
        string originalString = "  Hello, World! This is a C# string demonstration.  ";
        Console.WriteLine("Original String: '" + originalString + "'");

        // 1. ToUpper() - Converts the string to uppercase.
        string upperCaseString = originalString.ToUpper();
        Console.WriteLine("1. ToUpper(): " + upperCaseString);

        // 2. ToLower() - Converts the string to lowercase.
        string lowerCaseString = originalString.ToLower();
        Console.WriteLine("2. ToLower(): " + lowerCaseString);

        // 3. Trim() - Removes all leading and trailing white-space characters.
        string trimmedString = originalString.Trim();
        Console.WriteLine("3. Trim(): '" + trimmedString + "'");

        // 4. Contains() - Checks whether a specified substring exists.
        bool containsWorld = trimmedString.Contains("World");
        Console.WriteLine("4. Contains('World'): " + containsWorld);

        // 5. Substring() - Retrieves a substring from this instance.
        string substring = trimmedString.Substring(7, 5); // Starts at index 7, takes 5 characters
        Console.WriteLine("5. Substring(7, 5): " + substring);

        // 6. Replace() - Replaces all occurrences of a specified string.
        string replacedString = trimmedString.Replace("C#", "dotNET");
        Console.WriteLine("6. Replace('C#', 'dotNET'): " + replacedString);

        // 7. IndexOf() - Reports the zero-based index of the first occurrence of a character.
        int indexOfS = trimmedString.IndexOf('s');
        Console.WriteLine("7. IndexOf('s'): " + indexOfS);

        // 8. StartsWith() - Determines whether the beginning of this string instance matches a specified string.
        bool startsWithHello = trimmedString.StartsWith("Hello");
        Console.WriteLine("8. StartsWith('Hello'): " + startsWithHello);

        // 9. Split() - Splits a string into an array of substrings based on a delimiter.
        string[] words = trimmedString.Split(' ');
        Console.WriteLine("9. Split(' '): The first word is '" + words[0] + "'");

        // 10. Concat() - Concatenates two or more strings.
        string anotherString = " Let's add this.";
        string concatenatedString = string.Concat(trimmedString, anotherString);
        Console.WriteLine("10. Concat(): " + concatenatedString);
    }
}
