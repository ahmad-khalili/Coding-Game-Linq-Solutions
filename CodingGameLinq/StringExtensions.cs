namespace CodingGameLinq;

// Exercise 4 (Extension Methods Exercise):
// In this exercise, you must add an extension method, SayHello() to the built-in string type.
// The SayHello() method should return the string: "Hello, <subject>!"
public static class StringExtensions
{
    public static string SayHelloExercise4(this string str) => $"Hello, {str}!";
}