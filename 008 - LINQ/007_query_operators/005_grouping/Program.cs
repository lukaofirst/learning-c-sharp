/* --- Query Operators - Grouping --- */

using _005_grouping;

var personList = new List<Person>()
{
	new Person("John", "Male"),
	new Person("Maria", "Female"),
	new Person("Catherine", "Female"),
	new Person("Albert", "Male"),
	new Person("Christian", "Male"),
	new Person("Sarah", "Female"),
};

/* - .GroupBy() - */
var groupByResult = personList.GroupBy(x => x.Gender);
groupByResult.ToList().ForEach(group =>
{
	Console.WriteLine(group.Key);

	foreach (var person in group)
	{
		Console.WriteLine($"  {person.Name}");
	}
});
Console.WriteLine();

/* - .ToLookup() - */
var toLookupResult = personList.ToLookup(x => x.Gender);
toLookupResult.ToList().ForEach(group =>
{
	Console.WriteLine(group.Key);

	foreach (var person in group)
	{
		Console.WriteLine($"  {person.Name}");
	}
});