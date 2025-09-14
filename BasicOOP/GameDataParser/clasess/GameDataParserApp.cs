using GameDataParser.Interfaces;
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
        private readonly IUserInteractor _userInteractor;
        private readonly IVideoGameDeserialize _videoGameDeserializer;
        private readonly GamesPrinter _gamesPrinter;
        private readonly IFileReader _fileReader;
        public GameDataParserApp(
            IUserInteractor userInteractor, IVideoGameDeserialize videoGameDeserializer, GamesPrinter gamesPrinter, IFileReader fileReader)
        {
            _userInteractor = userInteractor;
            _videoGameDeserializer = videoGameDeserializer;
            _gamesPrinter = gamesPrinter;
            _fileReader = fileReader;
        }
        public void Run()
        {
            _userInteractor.PrintMessage("Game Data Parser Application Started.");

            //string fileContent = default;
            //var videoGames = default(List<VideoGame>); // devuelve el valor por defecto dependiendo del tipo de valor;
            var userInput = _userInteractor.ReadFilePathFromUser();
            var fileContent = _fileReader.Read(userInput);
            var videoGames = _videoGameDeserializer.Deserialize(userInput, fileContent);
            _gamesPrinter.Print(videoGames);
        }
    }
}
