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
    
    // Exercise 8 (Putting It Together Exercise):
    /* LINQ Select() method
    One of the more commonly used methods in LINQ is the Select() method. 
    Select() is an extension method to the IEnumerable<T> interface. 
    It is analogous to the map() method found in many other programming languages.

    Select() takes each element, one-at-a-time, from a source IEnumerable<T> sequence, 
    applies a delegate function to the elements, and then returns an IEnumerable<U> result.

    NOTE: The type inside the collection can change, hence the change from IEnumerable<T> to IEnumerable<U>.

    Implement a Transform() method
    In order to avoid the complications of dealing with generics in this exercise, 
    let's limit the extension method to only work with IEnumerable<int>. Here is what you need to do:

    - Implement an extension to IEnumerable<int> called Transform()
    - The Transform() method should accept, as a parameter, a delegate that takes an int input and returns an int output
    - The Transform() method should be a generator that iterates through the input IEnumerable<int>,
      applies the delegate to each value, and yield returns the result
    - The Transform() should return an IEnumerable<int> output
    */
    public delegate int TransformationFunction(int num);
    public static IEnumerable<int> Transform(this IEnumerable<int> collection, TransformationFunction func){
        foreach(var item in collection){
            var newItem = func(item);
            yield return newItem;
        }
    }
}