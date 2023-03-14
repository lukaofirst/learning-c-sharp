using _003_deferred_execution;

/* --- Deferred Execution --- */

var personsList = new List<Person>
{
	new Person { Name = "Bill", Age = 25 },
	new Person { Name = "Will", Age = 65 },
	new Person { Name = "Jane", Age = 70 },
	new Person { Name = "Jonathan", Age = 16 },
	new Person { Name = "Walter", Age = 37 },
	new Person { Name = "Mathews", Age = 29 },
};

var query = personsList.GetElegibleAdults();

foreach (var person in query)
	Console.WriteLine($"{person.Name} | {person.Age}");