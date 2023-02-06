/* --- Stack --- */

// This is not allowed, because it doesn't implements an .Add() method
//var stack = new Stack<int>() { 1, 2, 3 };

// but you can create a stack from a collection (array or lists)
var numbers = new List<int>() { 1, 32, 93, 2090 };

var stack = new Stack<int>(numbers);

stack.Push(3001);

foreach (var item in stack)
{
    // prints 3001, 2090, 93, 32, 1
    Console.WriteLine(item);
}

var poppedItem = stack.Pop();

Console.WriteLine($"The popped item is: {poppedItem}");

Console.WriteLine($"The peek is: {stack.Peek()}");