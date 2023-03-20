/* --- Query Operators - Filtering --- */

using _001_filtering;

var personList = new List<Person>()
{
	new Person(1, "Lorem", 25),
	new Person(1, "John", 33),
	new Person(1, "Bill", 19),
	new Person(1, "Ramsey", 40),
	new Person(1, "Washington", 22),
	new Person(1, "Ronald", 56),
};

var duplicatedNumbers = new int[] { 1, 1, 3, 4, 5, 5, 7, 7, 8, 10, 10 };

/* - .Where() - */
// Returns a IEnumerable<T> based on a predicate function
var resultWhere = personList.Where(x => x.Age > 40);

/* - .Take() and .TakeWhile() - */
// Take => Emits the first n elements and discards the rest
var resultTake = personList.Take(3);

// TakeWhile => Returns elements from the given collection until the specified condition is true
// If the first element itself doesn't satisfy the condition then returns an empty collection
var resultTakeWhile = personList.TakeWhile(x => x.Name.Length > 4);

/* - .Skip() and .SkipWhile() - */
// Skip => It skips the specified number of elements starting from the list and returns
// the rest of the elements
var resultSkip = personList.Skip(4);

// SkipWhile => It skips elements in the collection until the specified condition is true
var resultSkipWhile = personList.SkipWhile(x => x.Name.Length < 6);

/* - .Distinct() - */
// Returns distinct values from a collection
var resultDistinct = duplicatedNumbers.Distinct();

