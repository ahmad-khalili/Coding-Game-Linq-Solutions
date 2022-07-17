namespace CodingGameLinq;

public static class Program
{
    // Exercise 1:
    // In this exercise, write a lambda expression that returns the provided value plus one.
    public static Func<int, int> GetNextNumber = num => num + 1;
}