using GameDataParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDataParser.clasess
{
    public class VideoGamesRepository: IVideoGameDeserialize
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGamesRepository(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }
        public List<VideoGame> Deserialize(string fileName, string fileContent)
        {

            try
            {
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
            }
            catch (JsonException jex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                _userInteractor.PrintError("There was an error parsing the file content");
                _userInteractor.PrintError($"JSON in  {fileName} file");
                _userInteractor.PrintError($"JSON body {fileContent}");
                throw new JsonException($"{jex.Message} The file is : {fileName}", jex);
            }
        }
    }
}
