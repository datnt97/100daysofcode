
using Newtonsoft.Json;

var path = "C:\\";

var rootDirectory = new DirectoryInfo(path);
var dirctories = rootDirectory.GetDirectories();

foreach (var dir in dirctories)
{
    Console.WriteLine(dir.Attributes);
}
