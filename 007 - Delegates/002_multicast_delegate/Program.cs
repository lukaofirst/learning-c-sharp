/* --- Multicast Delegate --- */

// It points to multiple methods and executed on the same order that is appended/removed

// If them multicast delegates returns a value, the last one will prevail

CustomDelegate delA = ClassA.MethodA;
CustomDelegate delB = ClassB.MethodB;

CustomDelegate del = delA + delB;
del("A message");
Console.WriteLine();

CustomDelegate delC = (string msg) => Console.WriteLine($"Called by lambda expression: {msg}");
del += delC;
del("Another message");
Console.WriteLine();

del = (delA - delB)!;
del("Another another message");


class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine($"Called by ClassA.MethodA() method: {message}");
    }
}

class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine($"Called by ClassB.MethodB() method: {message}");
    }
}

delegate void CustomDelegate(string message);