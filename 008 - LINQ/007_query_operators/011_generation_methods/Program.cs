/* --- Query Operators - Generation Methods --- */

/* - Range - */
var rangeResult = Enumerable.Range(10, 5);
rangeResult.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

/* - Repeat - */
var repeatResult = Enumerable.Repeat(5, 5);
repeatResult.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

// Generating random CPFs
var random = new Random();
var chars = "0123456789";
const int cpfLength = 11;

var result = Enumerable.Repeat(chars, cpfLength)
	.Select(x => x[random.Next(x.Length)])
	.ToArray();

Console.WriteLine(result);