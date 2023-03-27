/* --- using block --- */

var sourcePath = @"./files/source.txt";

try
{
	// using var fs = new FileStream(sourcePath, FileMode.Open);
	// using var sr1 = new StreamReader(fs);

	// while (!sr1.EndOfStream)
	// {
	// 	var line = sr1.ReadLine();
	// 	Console.WriteLine(line);
	// }

	using var sr = File.OpenText(sourcePath);

	while (!sr.EndOfStream)
	{
		var line = sr.ReadLine();
		Console.WriteLine(line);
	}

}
catch (IOException ex)
{
	Console.WriteLine(ex.Message);
}
