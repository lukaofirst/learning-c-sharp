/* --- Extension Methods --- */

var number1 = 50;
var number2 = 5;
var strNumber = "94905389";

var resultIsGreaterThan = number1.IsGreaterThan(number2);
var (resultBool, resultInt) = strNumber.IsValidIntNumber();

Console.WriteLine(resultIsGreaterThan);
Console.WriteLine($"Is a valid number? {resultBool} - What is the int value? {resultInt}");

static class IntegerExtensions 
{
    public static bool IsGreaterThan(this int currValue, int comparedValue)
    {
        return currValue > comparedValue;
    }
} 

static class StringExtensions
{
    public static (bool, int) IsValidIntNumber(this string str)
    {
        if(int.TryParse(str, out int result))
        {
            return (true, result);
        }

        return (false, 0);
    }
}