/* --- Delegate --- */

// Ways to set a target method
CustomDelegate del1 = new CustomDelegate(PrintMessage);
CustomDelegate del2 = PrintMessage;
CustomDelegate del3 = (string msg) => Console.WriteLine(msg);

// Ways to execute a delegate
del1.Invoke("Hello world");
del2("Just a message to be printed");
del3("Another message");


static void PrintMessage(string message)
{
    Console.WriteLine($"Called by PrintMessage() method with parameter: {message}");
}

delegate void CustomDelegate(string message);