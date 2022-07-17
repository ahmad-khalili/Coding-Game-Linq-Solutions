﻿namespace CodingGameLinq;

public static class Program
{
    // Exercise 1:
    // In this exercise, write a lambda expression that returns the provided value plus one.
    public static Func<int, int> GetNextNumber = num => num + 1;
    
    // Exercise 2 (Query Syntax Exercise):
    // Now you try it out. The following code shows a LINQ query that returns the input inValues unmodified.
    // Using the format of the example above, see if you can return only the strings that have
    // pattern in them (using the String.Contains() method) and order the list alphabetically.
    public static IEnumerable<string> FilterAndSortQuery(IEnumerable<string> inValues, string pattern)
    {
        return from value in inValues
            where value.Contains(pattern)
            orderby value
            select value;
    }
    
    // Exercise 3 (Method Syntax Exercise):
    // This is the exact same exercise as in the previous lesson. Now try to write it with method syntax.
    // The following code shows a LINQ query that returns the input inValues unmodified. Using the format of the
    // example above, see if you can return only the strings that have
    // pattern in them (using the String.Contains() method) and order the list alphabetically.
    public static IEnumerable<string> FilterAndSortMethod(IEnumerable<string> inValues, string pattern)
    {
        return inValues
                .Where(value => value.Contains(pattern))
                .OrderBy(value => value)
            ;
    }
    
    // Exercise 4 (Extract a single element):
    // Using what you have learned about First(), Last(), ElementAt(), and Single() (and their variations) modify
    // the methods in this exercise to extract the desired element from the provided sequence of strings.
    public static string GetFirstSingleLetterWord(IEnumerable<string> words)
    {
        return words.First(word => word.Length == 1);
    }

    // Return the last word that contains the substring "her" in it.
    // There will always be at least one.
    public static string GetLastWordWithHerInIt(IEnumerable<string> words)
    {
        return words.Last(word => word.Contains("her"));
    }

    // Return the fifth word in the sequence, if there is one. If there are
    // fewer than 5 words, then return null.
    public static string GetFifthWordIfItExists(IEnumerable<string> words)
    {
        return words.ElementAtOrDefault(4);
    }

    // Return the last word in the sequence. If there are no words in
    // the sequence, return null.
    public static string GetLastWordIfAny(IEnumerable<string> words)
    {
        return words.LastOrDefault();
    }
}