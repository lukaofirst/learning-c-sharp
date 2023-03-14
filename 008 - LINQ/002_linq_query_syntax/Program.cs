/* --- LINQ Query Syntax --- */

var list = new List<string>()
{
	"C#",
	"JavaScript",
	"TypeScript",
	"Dart",
	"React",
	"Angular"
};

var query = (
	from item in list
	where item.Contains("a")
	select item
);

foreach (var item in query)
	Console.WriteLine(item);