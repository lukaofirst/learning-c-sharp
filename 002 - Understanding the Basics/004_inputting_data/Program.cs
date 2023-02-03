/* --- Inputting Data --- */
Console.WriteLine("Type something on console");
var input = Console.ReadLine();
Console.WriteLine(input);
Console.WriteLine();

// breaking input into multiple items, separated by ", "
Console.WriteLine("Breaking input into multiple items, separed by \", \"");
var inputs = Console.ReadLine();

var splittedInputs = inputs!.Split(", ");

foreach (var item in splittedInputs)
{
    Console.WriteLine(item);
}
Console.WriteLine();

// converting input data (for example to integers)
Console.WriteLine("Type a number to convert to an integer");
var integerInput = Console.ReadLine();

var result = int.Parse(integerInput!);
Console.WriteLine(result);