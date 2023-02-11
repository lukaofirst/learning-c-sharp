using _003_static_members;

/* --- Static Members --- */

// If a method doesn't access a instance member,
// the IDE will suggest you to mark as static

var sumResult = Calculator.Sum(20.1, 902.2);
var subtractResult = Calculator.Subtract(5.24, 0.23);
var poweredNumber = Math.Pow(10, 2);

Console.WriteLine(sumResult);
Console.WriteLine(subtractResult);
Console.WriteLine(poweredNumber);