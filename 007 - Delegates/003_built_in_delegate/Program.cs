/* --- Built-in Delegate --- */

/* - Func Delegate - */
Func<int, int, int> AddFunc = SumMethod; 
Func<int, bool> CheckIsAdultFunc = (int age) => age > 0;
Func<string, string> ConvertToUpperCaseFunc = delegate (string str) { return str.ToUpper(); };

var resultSum = AddFunc(20, 30);
var resultIsAdult = CheckIsAdultFunc(21);
var resultConvertToUpperCase = ConvertToUpperCaseFunc("hello");

Console.WriteLine(resultSum);
Console.WriteLine(resultIsAdult);
Console.WriteLine(resultIsAdult);
Console.WriteLine(resultConvertToUpperCase);
Console.WriteLine();

static int SumMethod(int x, int y)
{ 
    return x + y; 
}

/* - Action - */
Action<string> PrintMessageAction = PrintMessageMethod;
Action<int> PrintIntegerAction = (integer) => Console.WriteLine(integer);
Action<double> PrintDoubleAction = delegate (double doubleNum) { Console.WriteLine(doubleNum); };

PrintMessageAction("a message");
PrintIntegerAction(10);
PrintDoubleAction(10.25);
Console.WriteLine();

static void PrintMessageMethod(string message) => Console.WriteLine(message);

/* - Predicate - */
Predicate<Person> PersonIsValidPredicate = PersonIsValidMethod;

var resultPersonIsValid = PersonIsValidPredicate(new Person { Name = "Lorem", Age = 25 });
Console.WriteLine(resultPersonIsValid);

static bool PersonIsValidMethod(Person person) => !string.IsNullOrEmpty(person.Name) && person.Age > 0;