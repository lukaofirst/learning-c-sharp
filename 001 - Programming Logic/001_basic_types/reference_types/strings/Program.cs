/* --- Basic Types --- */

/* - strings - */
var example = "Lorem";

// string with special characters 
var specialStr = "I'm a special string \n another line";

// Verbatim strings
var verbatimStr = @"I'm a ""verbatim"" string 
    with break line";

Console.WriteLine(example);
Console.WriteLine(specialStr);
Console.WriteLine(verbatimStr);
Console.WriteLine();

// Concatenation
var firstName = "Lorem";
var lastName = "Ipsum";
Console.WriteLine("Concatenation => The fullname is:" + " " + firstName + " " + lastName);

// Composite Formatting
Console.WriteLine("Composite Formatting => The fullname is {0} {1}", firstName, lastName);

// Interpolation (the recommended approach)
Console.WriteLine($"Interpolation => The fullname is {firstName} {lastName}");
