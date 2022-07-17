namespace CodingGameLinq;

public static class StringExtensions
{
    // Exercise 4 (Extension Methods Exercise):
    // In this exercise, you must add an extension method, SayHello() to the built-in string type.
    // The SayHello() method should return the string: "Hello, <subject>!"
    public static string SayHelloExercise4(this string str) => $"Hello, {str}!";
    
    // Exercise 5 (Extension Method Parameters Exercise):
    // Try adding another extension method to the string type. This time, call it MakePlural().
    // The MakePlural() method should take an int parameter and return a string
    // that is either the original string if the parameter is 1,
    // or the string with an 's' appended to it if the parameter is not equal to 1.
    public static string MakePlural(this string str, int plural){
        if (plural == 1){
            return str;
        }
        else{
            return str + "s";
        }
    }
}