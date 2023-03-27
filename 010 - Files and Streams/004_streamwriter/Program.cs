/* --- StreamWriter --- */

// using dotnet CLI it works fine
var targetPath = "./files/target.txt";

// but in case if you're not
// you have to "find" the root directory of your project
// var absPath = Directory.GetParent(Directory.GetCurrentDirectory())!.Parent!.FullName;
// var fullPath = absPath + targetPath;
//Console.WriteLine(absPath);

var sw = new StreamWriter(targetPath);

sw.WriteLine("lorem ipsum dolor sit amet");
sw.WriteLine("consectetur adipiscing elit");
sw.WriteLine("suspendisse aliquet eget nisi non ultricies");

sw.Close();