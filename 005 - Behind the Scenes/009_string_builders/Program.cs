/* --- String Builders --- */

using System.Text;

var str = "Hello world from C#";

// Faster
var strBuilder = new StringBuilder();

foreach (var item in str)
{
    strBuilder.Append(item);
}

Console.WriteLine(strBuilder.ToString());

// Slower
//var str2 = string.Empty;

//foreach(var item in str)
//{
//    str2 += str;
//}

//Console.WriteLine(str2);