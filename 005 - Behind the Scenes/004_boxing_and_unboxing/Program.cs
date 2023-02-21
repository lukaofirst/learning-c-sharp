/* --- Boxing and Unboxing --- */

/* - Boxing - */
// implicit => the compiler will try to convert int to a object type
// object is a super type in C#
int x = 10;
object obj = x;
Console.WriteLine(obj);

/* - Unboxing - */
// explicit => you need to tell the compiler the correct type
// do not use the double type here, otherwise you'll receive
// a runtime error (InvalidCastException)
// unless if you use the Convert.ToDouble() method
int y = (int)obj;

Console.WriteLine(y);
