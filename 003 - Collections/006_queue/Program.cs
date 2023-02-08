/* --- Queue --- */

// This is not allowed, because it doesn't implements an .Add() method
// var queue = new Queue<int>() { 1, 2, 3 };

// but you can create a stack from a collection (array or lists)
var numbers = new List<int>() { 1, 32, 93, 2090 };

var queue = new Queue<int>(numbers);

queue.Enqueue(3001);

foreach (var item in queue)
{
    // prints 1, 32, 93, 2090, 3001
    Console.WriteLine(item);
}

var dequeuedItem = queue.Dequeue();

Console.WriteLine($"The dequeued item is: {dequeuedItem}");

Console.WriteLine($"The peek is: {queue.Peek()}");