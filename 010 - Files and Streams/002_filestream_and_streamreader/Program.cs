/* --- FileStream and StreamReader --- */

var sourcePath = @"./files/source.txt";

//FileStream? fs = null;

// more verbose
// try
// {
// 	fs = new FileStream(sourcePath, FileMode.Open);
// 	var sr1 = new StreamReader(fs);

// 	while (!sr1.EndOfStream)
// 	{
// 		var line = sr1.ReadLine();
// 		Console.WriteLine(line);
// 	}
// }
// catch (IOException ex)
// {
// 	Console.WriteLine(ex.Message);
// }
// finally
// {
// 	if (fs != null)
// 		fs.Close();
// }

// // less verbose
StreamReader? sr = null;
try
{
	sr = File.OpenText(sourcePath);

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
finally
{
	if (sr != null)
		sr.Close();
}