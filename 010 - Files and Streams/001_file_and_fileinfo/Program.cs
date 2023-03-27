/* --- File and FileInfo --- */

try
{
	var sourcePath = @"./files/source.txt";
	var targetPath = @"./files/target.txt";

	var content = File.ReadAllLines(sourcePath);
	File.Copy(sourcePath, targetPath);

	foreach (var line in content)
		Console.WriteLine(line);
}
catch (IOException ex)
{
	Console.WriteLine(ex.Message);
}
