using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string");
        string input = Console.ReadLine();

        // Regular expression used to find valid dates in mmddyyyy format
        var dateMatches = FindValidDates(input); 
        if (dateMatches.Count > 0)
        {
            Console.WriteLine("Valid Dates found in the string");
            foreach (var date in dateMatches)
            {
                Console.WriteLine(date);
            }
        }
        else
        {
            Console.WriteLine("No Vaild dates found in the string");
        }
    }
     static MatchCollection FindValidDates(string input)
    {
        // Regular expression Defined for mmddyyyy format
        string pattern = @"\b(\d{2})(\d{2})(\d{4})\b"; 

        // Regular Expression used to find matches in input string
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        return matches;
    }
}