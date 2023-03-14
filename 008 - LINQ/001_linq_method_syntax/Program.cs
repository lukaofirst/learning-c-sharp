/* --- LINQ Method Syntax --- */
var list = new List<string>()
{
	"C#",
	"JavaScript",
	"TypeScript",
	"Dart",
	"React",
	"Angular"
};

var query = list.Where(x => x.Contains("a"));

foreach (var item in query)
	Console.WriteLine(item);