/* --- Dictionary --- */

var dict = new Dictionary<int, string>();

dict.Add(1, "lorem");
dict.Add(2, "ipsum");

foreach (var item in dict)
{
    Console.WriteLine($"hash code: {item.GetHashCode()} | key: {item.Key} | value: {item.Value}");
}

var cities = new Dictionary<string, string>()
{
    { "United Kingdom", "Liverpool, London, Manchester" },
    { "Spain", "Barcelona, Madrid, Sevilla" }
};

if (cities.ContainsValue("France"))
    Console.WriteLine("It contains France");