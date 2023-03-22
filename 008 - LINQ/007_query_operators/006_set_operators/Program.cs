/* --- Query Operators - Set Operators --- */

var numberList1 = new List<int>() { 1, 5, 3, 5, 3 };
var numberList2 = new List<int>() { 2, 4, 4, 2 };

var numberList3 = new List<int>() { 1, 5, 3, 5, 3 };
var numberList4 = new List<int>() { 2, 4, 5, 3 };

/* - Concat - */
var concatResult = numberList1.Concat(numberList2);
concatResult.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

/* - Union - */
var unionResult = numberList1.Union(numberList2);
unionResult.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

/* - Intersect - */
var intersectResult = numberList3.Intersect(numberList4);
intersectResult.ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine();

/* - Except - */
var exceptResult = numberList3.Except(numberList4);
exceptResult.ToList().ForEach(x => Console.WriteLine(x));