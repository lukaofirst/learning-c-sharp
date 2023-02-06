/* --- Lists --- */

var list = new List<string>();
var arr = new string[] { "hello", "world" };

list.Add("lorem");
list.Add("ipsum");
list.Add("dolor");

list.AddRange(arr);

foreach (var item in list)
{
    Console.WriteLine(item);
}

