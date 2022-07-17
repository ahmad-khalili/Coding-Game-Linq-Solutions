namespace CodingGameLinq;

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
    
    // Exercise 5 (Take & Skip Exercise):
    // In this exercise, make the GetThirdFourthFifthItems() method return the 3rd, 4th, and
    // 5th elements of the provided sequence.
    public static IEnumerable<string> GetThirdFourthFifthItems(
        IEnumerable<string> words)
    {
        return words.Skip(2).Take(3);
    }
    
    // Exercise 6 (TakeWhile and SkipWhile Exercise):
    // In this exercise, make the GetStartThroughEnd() method return all the words from the provided
    // sequence that occur between the words "start" (inclusive) and "end" (non-inclusive).
    public static IEnumerable<string> GetStartThroughEnd(IEnumerable<string> words)
    {
        return words.SkipWhile(word => word != "start").TakeWhile(word => word != "end");
    }
    
    // Exercise 7 (Distinct, Intersect, and Where Exercise):
    // In this exercise, make the GetDistinctShortWords() method return the words from the
    // provided sequence that have fewer than four letters in them and are distinct.
    public static IEnumerable<string> GetDistinctShortWords(
        IEnumerable<string> words)
    {
        return words.Where(word => word.Length < 4).Distinct();
    }
    
    // Exercise 8 (OrderBy Exercise):
    // In the following exercise, try to sort all the input names by Last, in descending order.
    /* public interface IName
    {
        string First { get; }
        string Middle { get; }
        string Last { get; }
    }*/
    public static IEnumerable<IName> SortNames(IEnumerable<IName> names)
    {
        return names.OrderByDescending(name => name.Last);
    }
}