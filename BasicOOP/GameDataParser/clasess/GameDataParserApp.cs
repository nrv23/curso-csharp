using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParser.clasess
{
    public class GameDataParserApp
    {
        private readonly Logger _logger;
        public GameDataParserApp(Logger logger)
        {
            _logger = logger;
        }
        public void Run()
        {
            Console.WriteLine("Game Data Parser Application Started.");

            //string fileContent = default;
            //var videoGames = default(List<VideoGame>); // devuelve el valor por defecto dependiendo del tipo de valor;
            var userInput = ReadFilePathFromUser();
            var fileContent = File.ReadAllText(userInput);
            var videoGames = DeserializeVideoGames(userInput, fileContent);
            PrintVideoGames(videoGames);
        }

        private static void PrintVideoGames(List<VideoGame> videoGames)
        {
            if (videoGames.Count() > 0)
            {
                Console.WriteLine($"Loaded games");
                foreach (var game in videoGames)
                {
                    Console.WriteLine(game.ToString());
                }
            }
            else
            {
                Console.WriteLine("There is not results");
            }
        }

        private static string ReadFilePathFromUser()
        {

            bool isValidPath = false;
            string value;
            // devuelve el valor por defecto dependiendo del tipo de valor;
            do
            {

                Console.WriteLine("Enter the file name you want to read");
                value = Console.ReadLine();

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("user input can not be empty or null");
                }
                else if (!File.Exists(value))
                {

                    Console.WriteLine($"{value} is not exists");
                }

                else
                {
                    isValidPath = true;
                    //var filePath = Path.Combine(Directory.GetCurrentDirectory(), "GameData", fileName); esta linea es como un path.join y __dirname en node
                    //var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameData", fileName); // esta linea es como un path.join y __dirname en node

                }

            } while (!isValidPath);

            return value;

        }

        private static List<VideoGame> DeserializeVideoGames(string fileName, string fileContent)
        {

            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
            }
            catch (JsonException jex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There was an error parsing the file content");
                Console.WriteLine($"JSON in  {fileName} file");
                Console.WriteLine($"JSON body {fileContent}");
                Console.ResetColor();
                throw new JsonException($"{jex.Message} The file is : {fileName}", jex);
            }
        }
    }
}
