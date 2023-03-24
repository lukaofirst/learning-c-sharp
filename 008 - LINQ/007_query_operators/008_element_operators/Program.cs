/* --- Query Operators - Element Operators --- */

var numbers = new int[] { 1, 3, 5, 10, 300, 5000 };

/* - .First() and .FirstOrDefault() - */
var firstResult = numbers.First();
var firstOrDefaultResult = numbers.FirstOrDefault();
Console.WriteLine($".First() - {firstResult}");
Console.WriteLine($".FirstOrDefault() - {firstOrDefaultResult}");
Console.WriteLine();

/* - .Last() and .LastOrDefault() - */
var lastResult = numbers.Last();
var lastOrDefaultResult = numbers.LastOrDefault();
Console.WriteLine($".Last() - {lastResult}");
Console.WriteLine($".LastOrDefault() - {lastOrDefaultResult}");
Console.WriteLine();

/* - .Single() and .SingleOrDefault() - */
var singleResult = numbers.Single(x => x == 10);
var singleOrDefaultResult = numbers.SingleOrDefault(x => x == 10);
Console.WriteLine($".Single() - {singleResult}");
Console.WriteLine($".SingleOrDefault() - {singleOrDefaultResult}");
Console.WriteLine();

/* - .ElementAt() and .ElementAtOrDefault() - */
var elementAtResult = numbers.ElementAt(5);
var elementAtOrDefaultResult = numbers.ElementAtOrDefault(5);
Console.WriteLine($".ElementAt() - on index 5 - {elementAtResult}");
Console.WriteLine($".ElementAtOrDefault() - on index 5 - {elementAtOrDefaultResult}");