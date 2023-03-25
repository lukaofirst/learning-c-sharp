/* --- Query Operators - Quantifiers --- */

using _010_quantifiers;

var numbers = new int[] { 1, 3, 5, 7, 9 };

var persons = new List<Person>()
{
	new Person("John", 33),
	new Person("Arthur", 24),
	new Person("Dutch", 35),
};
var person1 = new Person("John", 33);

var personsSequenceEqual1 = new List<Person>()
{
	new Person("Michael", 25),
	new Person("Franklin", 23),
	new Person("Trevor", 22),
};
var personsSequenceEqual2 = new List<Person>()
{
	new Person("Michael", 25),
	new Person("Franklin", 23),
	new Person("Trevor", 22),
};

/* - .Contains() - */
var containsResult = numbers.Contains(2);
var wrongContainsResult = persons.Contains(person1);
var correctContainsResult = persons.Contains(person1, new PersonComparer());
Console.WriteLine($".Contains() - {containsResult}");
Console.WriteLine($"wrongContainsResult - {wrongContainsResult}");
Console.WriteLine($"correctContainsResult - {correctContainsResult}");
Console.WriteLine();

/* - .Any() - */
var anyResult = numbers.Any();
var anyConditionResult = numbers.Any(x => x > 5);

Console.WriteLine($".Any() - {anyResult}");
Console.WriteLine($".Any() - {anyConditionResult}");
Console.WriteLine();

/* - .All() - */
var allResult = numbers.All(x => x > 3);
Console.WriteLine($".All() - {allResult}");
Console.WriteLine();

/* - .SequenceEqual() - */
var wrongSequenceEqualResult = personsSequenceEqual1.SequenceEqual(personsSequenceEqual2);
var correctSequenceEqualResult = personsSequenceEqual1.SequenceEqual(personsSequenceEqual2, new PersonComparer());

Console.WriteLine($"wrongSequenceEqualResult - {wrongSequenceEqualResult}");
Console.WriteLine($"correctSequenceEqualResult - {correctSequenceEqualResult}");