/* --- Query Operators - Aggregation Methods --- */

var numbers = new int[] { 1, 3, 5, 10, 300, 5000 };
var numbersAsStrings = new string[] { "One", "Two", "Three", "Four", "Five" };

/* - .Count() and .LongCount() - */
var countResult = numbers.Count();
var countOnPredicateResult = numbers.Count(x => x > 20);
var longCountResult = numbers.LongCount();
Console.WriteLine($".Count() - {countResult}");
Console.WriteLine($".Count() - based on predicate - {countOnPredicateResult}");
Console.WriteLine($".LongCount() - {longCountResult}");
Console.WriteLine();

/* - .Min() and .Max() - */
var minResult = numbers.Min();
var maxResult = numbers.Max();
Console.WriteLine($".Min() - {minResult}");
Console.WriteLine($".Max() - {maxResult}");
Console.WriteLine();

/* - .Sum() and .Average() - */
var sumResult = numbers.Sum();
var averageResult = numbers.Average();
Console.WriteLine($".Sum() - {sumResult}");
Console.WriteLine($".Average() - {averageResult}");
Console.WriteLine();

/* - .Aggregate() - */
var aggregateResult = numbersAsStrings.Aggregate((n1, n2) => $"{n1} - {n2}");
Console.WriteLine(aggregateResult);
