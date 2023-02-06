using System.Collections;

/* --- Hashtable --- */

var hashTable = new Hashtable()
{
    { 1, "lorem" }
};

hashTable.Add("2", "two");
hashTable.Add("hello", "3");

foreach (DictionaryEntry item in hashTable)
{
    Console.WriteLine($"hash code: {item.GetHashCode()} | key: {item.Key} | value: {item.Value}");
}
