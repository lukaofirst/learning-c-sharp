/* --- Subqueries --- */

using _004_subqueries;

var personsList = new List<Person>
{
	new Person { Name = "Bill", Age = 25 },
	new Person { Name = "Will", Age = 65 },
	new Person { Name = "Jane", Age = 70 },
	new Person { Name = "Jonathan", Age = 16 },
	new Person { Name = "Walter", Age = 37 },
	new Person { Name = "Mathews", Age = 29 },
};

var filteredByPersonNames = new List<string>
{
	"Bill", "Jane", "Will"
};

var query = personsList
	.Where(x => filteredByPersonNames.Contains(x.Name));

foreach (var item in query)
	Console.WriteLine(item.Name);