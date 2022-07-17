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
    
    // Exercise 9 (ThenBy Exercise):
    // In the following exercise, try to order all the input names by Last. If any names have the same value for Last,
    // then they should be ordered by First.
    // If any have matching Last and First, then they should be ordered by Middle.
    /* public interface IName
    {
        string First { get; }
        string Middle { get; }
        string Last { get; }
    }*/
    public static IEnumerable<IName> SortNames(IEnumerable<IName> names)
    {
        return names.OrderBy(name => name.Last).ThenBy(name => name.First).ThenBy(name => name.Middle);
    }
    
    // Exercise 10 (Count Exercise):
    // In the following exercise, count the number of strings in the provided sequence that begin with the provided string.
    public static int NumberThatStartWith(IEnumerable<string> words, string startString)
    {
        return words.Count(word => word.StartsWith(startString));
    }
    
    // Exercise 11 (Min / Max Exercise):
    // In the following exercise, write a method that will return the length of
    // the shortest string in the provided sequence as an integer value.
    public static int LengthOfShortestWord(IEnumerable<string> words)
    {
        return words.Min(word => word.Length);
    }
    
    // Exercise 12 (Aggregate Exercise):
    // Think you can handle it? Try to use Aggregate() to write a method that will return the total
    // number of characters in all the words in the source sequence.
    public static int TotalCharactersInSequence(IEnumerable<string> words)
    {
        return words.Aggregate(0, (count, val) => count + val.Length);
    }
    
    // Exercise 13 (Select Exercise):
    // In this exercise, try to return a sequence of strings that
    // consist of the provided names in the form: "<Last>, <First>".
    /* public interface IName
    {
        string First { get; }
        string Middle { get; }
        string Last { get; }
    }*/
    public static IEnumerable<string> DisplayStringsForNames(IEnumerable<IName> names)
    {
        return names.Select(name => $"{name.Last}, {name.First}");
    }
    
    // Exercise 14 (Combined Exercise 1):
    // In this exercise, combine LINQ method calls together to determine if the second sequence passed
    // into the TestForSquares() method contains the squares of the elements in the first sequence.
    // It should return true if the two sequences have the same number of elements and each element in squares
    // is equal to the square of the corresponding element in numbers.
    public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
    {
        return squares
                .SequenceEqual(numbers.Select(number => number * number))
            ;
    }
}