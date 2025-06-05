using System;
using System.Collections.Generic;

class Program
{
    // Duplication Method with exception handling
    public static bool IsDuplicate(List<int> numbers)
    {
        try
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Error: The numbers list is null.");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred in IsDuplicate: {ex.Message}");
            return false;
        }
    }

    // Check if have vowels with exception handling
    public static bool HaveVowels(string text = "")
    {
        try
        {
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
            
            if (string.IsNullOrEmpty(text))
                return false;

            for (int i = 0; i < vowels.Count; i++)
            {
                if (text.ToLower().Contains(vowels[i]))
                {
                    return true;
                }
            }
            return false;
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Error: The text string is null.");
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred in HaveVowels: {ex.Message}");
            return false;
        }
    }

    static void Main()
    {
        try
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4 };

            bool duplication = IsDuplicate(numbers);

            if (duplication)
                Console.WriteLine("There is Duplication");
            else
                Console.WriteLine("No Duplication");

            bool have = HaveVowels("RSD");

            if (have)
                Console.WriteLine("Contains Vowels");
            else
                Console.WriteLine("Doesn't Contain Vowels");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred in Main: {ex.Message}");
        }
    }
}