/* --- Directory and DirectoryInfo --- */

var currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine(currentDirectory);

var directoryExists = new DirectoryInfo(currentDirectory).Exists;
Console.WriteLine(directoryExists);

var directories = Directory.EnumerateDirectories(currentDirectory, "*.*", SearchOption.AllDirectories);
foreach (var item in directories)
	Console.WriteLine(item);

Console.WriteLine();

var files = Directory.EnumerateFiles(currentDirectory, "*.*", SearchOption.AllDirectories);
foreach (var item in files)
	Console.WriteLine(item);


