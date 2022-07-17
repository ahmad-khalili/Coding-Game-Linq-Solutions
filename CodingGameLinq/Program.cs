namespace CodingGameLinq;

public static class Program
{
    // Exercise 1 (Delegates Exercise):
    // Declare a new type SayHello as a delegate that takes a single string parameter and returns a string result.
    public static void PrintAnswer(string func)
    {
        Console.WriteLine(func);
    }
    public delegate string SayHello(string str);
    public static void CallSayHelloDelegate(SayHello func)
    {
        PrintAnswer(func("World"));
        PrintAnswer(func("my baby"));
        PrintAnswer(func("my honey"));
    }
}