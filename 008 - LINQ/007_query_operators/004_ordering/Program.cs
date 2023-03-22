/* --- Query Operators - Ordering --- */

using _004_ordering;

var personList = new List<Person>()
{
	new Person("Oliver", 22),
	new Person("Oliver", 16),
	new Person("John", 30),
	new Person("Bill", 40),
	new Person("Harry", 28),
};

/* --- .OrderBy() and .ThenBy() --- */
var orderAndThenByResult = personList.OrderBy(x => x.Name);
orderAndThenByResult.ToList().ForEach(x => Console.WriteLine($"{x.Name} | {x.Age}"));
Console.WriteLine();

/* --- .OrderByDescending() and .ThenByDescending() --- */
var orderAndThenByDescendingResult = personList.OrderByDescending(x => x.Name).ThenByDescending(x => x.Age);
orderAndThenByDescendingResult.ToList().ForEach(x => Console.WriteLine($"{x.Name} | {x.Age}"));
Console.WriteLine();