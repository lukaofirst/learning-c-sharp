/* --- String Methods --- */

// Remember, in C# a string is immutable
// even you perform these string method the 'originalString' variable
// will remain the same

var originalString = "abcde FGHIJ ABC abc DEFG   ";

// Format
var toLowerString = originalString.ToLower();
var toUpperString = originalString.ToUpper();
var trimString = originalString.Trim();

// Find
var indexOfString = originalString.IndexOf("AB");
var lastIndexOfString = originalString.LastIndexOf("DE");

// Cut
var substring1 = originalString.Substring(4);
var substring2 = originalString.Substring(5, 3);

// Replace
var replaceStr = originalString.Replace("ABC", "_replacedText_");

// Padding
var padLeftStr = originalString.PadLeft(originalString.Length + 5, '0');
var padRightStr = originalString.PadRight(originalString.Length + 5, '0');

// Checking for nullable values
var checkIsNullOrEmpty = string.IsNullOrEmpty(originalString);
var checkIsNullOrWhiteSpace = string.IsNullOrWhiteSpace(originalString);

// Split
var splittedStrArr = originalString.Split(" ");

// Join
var joinedStr = string.Join("--", originalString.Split(" "));
    
Console.WriteLine($"originalString: {originalString}");

Console.WriteLine($"ToLower: {toLowerString}");
Console.WriteLine($"ToUpper: {toUpperString}");
Console.WriteLine($"Trim: {trimString}");
Console.WriteLine();

Console.WriteLine($"IndexOf: {indexOfString}");
Console.WriteLine($"LastIndexOf: {lastIndexOfString}");
Console.WriteLine();

Console.WriteLine($"Substring(4): {substring1}");
Console.WriteLine($"Substring(5, 3): {substring2}");
Console.WriteLine();

Console.WriteLine($"Replace: {replaceStr}");
Console.WriteLine();

Console.WriteLine($"PadLeft: {padLeftStr}");
Console.WriteLine($"PadRight: {padRightStr}");
Console.WriteLine();

Console.WriteLine($"IsNullOrEmpty: {checkIsNullOrEmpty}");
Console.WriteLine($"IsNullOrWhiteSpace: {checkIsNullOrWhiteSpace}");
Console.WriteLine();

foreach (var item in splittedStrArr)
{
    Console.WriteLine($"Split: {item}");
}
Console.WriteLine();

Console.WriteLine($"Join: {joinedStr}");

