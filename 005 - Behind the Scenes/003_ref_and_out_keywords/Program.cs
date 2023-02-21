/* --- ref and out keywords --- */

/* - ref - */
// you must initialize the 'x' variable
int x = 10;
Calculator.TripleNumberUsingRef(ref x);
Console.WriteLine(x);

/* - out - */
// you don't need to initialize the variable
int y = 20;
int z;
Calculator.TripleNumberUsingOut(y, out z);
Console.WriteLine(z);

// Example: using .TryParse() to validate a string as a valid number
var customerDocument = "11111111111";

if(long.TryParse(customerDocument, out long result))
{
    Console.WriteLine("It's a valid document");
}


class Calculator
{
    public static void TripleNumberUsingRef(ref int x)
    {
        x *= 3;
    }

    public static void TripleNumberUsingOut(int a, out int result)
    {
        result = a * 3;
    }
}
