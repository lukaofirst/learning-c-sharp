/* --- params keyword --- */

var numbersArr = new int[] { 1, 2, 3 };

var result1 = Calculator.Sum(numbersArr);
var result2 = Calculator.Sum(20, 10, 50);

Console.WriteLine(result1);
Console.WriteLine(result2);

class Calculator
{
    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }
}