/* --- Type Casting --- */

// Implicit Casting
int num1 = 10;
double num2 = num1;
Console.WriteLine(num2);

// Explicit Casting
double num3 = 20.2345;
int num4 = (int)num3;
Console.WriteLine(num4);

// Type Conversion Methods
float num5 = 34903.2390F;
var num6 = Convert.ToInt32(num5);
Console.WriteLine(num6);

string isAdult = "true";
var num7 = Convert.ToBoolean(isAdult);
Console.WriteLine(num7);