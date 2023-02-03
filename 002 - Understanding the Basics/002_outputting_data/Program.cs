using System.Globalization; 

/* --- Outputting Data --- */

// Pritting data on console

Console.WriteLine("hello world");
Console.Write("another text");
Console.WriteLine();

// Outputting and formatting double values
double number = 20.4523;

// 20.45
Console.WriteLine(number.ToString("F2"));

// 20.4523
Console.WriteLine(number.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine();

// Placeholders, Concatenate and Interpolation with double values, respectivelly
var name = "Lorem";
var age = 25;
var balance = 1290.1;
Console.WriteLine("{0} has {1} years old, and has ${2:F2}", name, age, balance);
Console.WriteLine(name + " has " + age + " years old, and has $" + balance.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine($"{name} has {age} years old, and has ${balance.ToString("F2", CultureInfo.InvariantCulture)}");