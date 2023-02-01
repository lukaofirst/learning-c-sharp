using _002_conditionals;

var age = 25;
const int adultAge = 21;

// Using if-else
if (age >= adultAge)
{
	Console.WriteLine("He/she is adult");
}
else
{
	Console.WriteLine("He/she is not adult");
}

// Using ternary operator
var myAge = 23;
var amIAdult = myAge >= adultAge ? true : false;

// Using switch-case
var pickOperation = (MathOperationsEnum)3;

switch (pickOperation)
{
	case MathOperationsEnum.Add:
		Console.WriteLine("Sum");
		break;
	case MathOperationsEnum.Subtract:
		Console.WriteLine("Subtract");
		break;
	case MathOperationsEnum.Multiply:
		Console.WriteLine("Multiply");
		break;
	case MathOperationsEnum.Divide:
		Console.WriteLine("Divide");
		break;
	default:
		throw new Exception("Something went wrong");
}