/* --- Query Operators - Conversion Methods --- */

using System.Collections;
using _007_conversion_methods;

var numbers = new int[] { 1, 3, 5 };
var arrayList = new ArrayList();
var personList = new List<Person>()
{
	new Person(1, "Lorem"),
	new Person(2, "Ipsum"),
	new Person(3, "Dolor"),
};

arrayList.AddRange(numbers);
arrayList.Add(DateTime.Now);

/* - .OfType() and .Cast() - */
var ofTypeResult = arrayList.OfType<int>();

foreach (var item in ofTypeResult)
	Console.WriteLine(item);

var castResult = arrayList.Cast<int>();
foreach (var item in castResult)
	Console.WriteLine(item);

Console.WriteLine("---------------------");

/* - .ToArray() - */
var toArrayResult = personList.ToArray();

/* - .ToDictionary() - */
var toDictionaryResult = personList.ToDictionary(x => x.Id, x => x.Name);

foreach (var item in toDictionaryResult)
	Console.WriteLine($"{item.Key} - {item.Value}");


