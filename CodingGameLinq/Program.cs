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
}