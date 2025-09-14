using System.Text.Json;
using GameDataParser.clasess;

Console.WriteLine("Enter the file name you want to read");

var fileName = Console.ReadLine();
//var filePath = Path.Combine(Directory.GetCurrentDirectory(), "GameData", fileName); esta linea es como un path.join y __dirname en node
//var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameData", fileName); // esta linea es como un path.join y __dirname en node

var fileCotent = File.ReadAllText(fileName);
var videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileCotent);

if( videoGames.Count() > 0)
{
    Console.WriteLine($"Loaded games");
    foreach (var game in videoGames)
    {
        Console.WriteLine( game.ToString());
    }
}
else
{
    Console.WriteLine("There is not results");
}
Console.ReadKey();