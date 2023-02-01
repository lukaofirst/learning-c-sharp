/* --- Loops --- */

var arr = new int[] { 349, 2309, 23904, 12903, 1293, 902 };

// while
Console.WriteLine("Using while loop");
var counter = 0;
while (counter < arr.Length)
{
	Console.WriteLine($"{arr[counter]}");
	counter++;
}

Console.WriteLine();

// for
Console.WriteLine("Using for loop");
for (var i = 0; i < arr.Length; i++)
{
	Console.WriteLine($"{i}: {arr[i]}");
}

Console.WriteLine();

// optional syntax: foreach
Console.WriteLine("Using foreach loop");
foreach (var item in arr)
{
	Console.WriteLine(item);
}
