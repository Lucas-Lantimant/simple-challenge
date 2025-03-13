using System;

public class ReverseString
{
    public static void Execute()
    {
        Console.Write("Enter a string to reverse: ");
        string input = Console.ReadLine() ?? string.Empty;

        string reversedString = Reverse(input);

        Console.Clear();
        Console.WriteLine("Reversed string: " + reversedString);
    }

    public static string Reverse(string str)
    {
        if (str == null) return string.Empty;

        char[] charArray = new char[str.Length];
        int j = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            charArray[j] = str[i];
            j++;
        }

        return new string(charArray);
    }
}
