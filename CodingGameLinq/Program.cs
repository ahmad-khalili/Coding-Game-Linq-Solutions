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
    
    // Exercise 2 (Delegate Variable Exercise):
    // In this exercise, you must use either a method delegate or a lambda expression to
    // define the HelloFunc variable such that it produces the desired results.
    // The required delegate takes a single string argument and returns a string result.
    public static readonly SayHello HelloFunc = (str) => $"Hello, {str}!";
    
    // Exercise 3 (Delegate Parameters Exercise):
    // In this exercise, you must pass either a method delegate or a lambda expression to the
    // TestSayHello() method in order to produce the desired result.
    // The delegate parameter takes a single string argument and returns a string result.
    public static SayHello TestSayHello(SayHello func)
    {
        return func;
    }
    public static void DoSayHello()
    {
        // Uncomment the call to TestSayHello() 
        //
        // The method Exercise.TestSayHello() takes a
        // SayHello delegate as input. Pass it a delegate
        // method that, when given a string "foo", will
        // return the string "Hello, foo!".

        TestSayHello(str => $"Hello, {str}!");
    }
    
    // Exercise 6 (Unbounded Generator Exercise):
    // See if you can write your own generator method that implements the following sequence:
    /* Alternate between adding 2 to the previous number, then multiplying the previous number by 2.
     Here are the first several values in this sequence:
     0+2, 2x2, 4+2, 6x2, 12+2, 14x2, 28+2, 30x2, 60+2 ...
     = 2,   4,   6,   12,  14,   28,   30,   60,   62 ...
    */
    public static IEnumerable<int> AddTwoThenDouble(){
        int latestValue = 0;
        bool isAdd = true;
            
        while (true) {
            latestValue = (isAdd ? latestValue + 2 : latestValue * 2);
            isAdd = !isAdd;
            yield return latestValue;
        }
    }
}