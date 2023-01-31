/* --- Basic Types --- */

/* - nullables - */
Nullable<int> num1 = null;

num1 = 10;

if(num1.HasValue)
    Console.WriteLine(num1);

// ? operator - shorthand syntax (recommended usage)
int? num2 = null;
Console.WriteLine(num2.GetValueOrDefault());

// ?? operator - Nullish Coalescing
// if num2 is null, return the right side, in this case 50;
var result = num2 ?? 50;
Console.WriteLine(result);
