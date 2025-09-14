using GameDataParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.clasess
{
    public class GamesPrinter: IGamesPrinter
    {
        private readonly IUserInteractor _userInteractor;

        public GamesPrinter(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }
        public void Print(List<VideoGame> videoGames)
        {
            if (videoGames.Count() > 0)
            {
                _userInteractor.PrintMessage($"Loaded games");
                foreach (var game in videoGames)
                {
                    Console.WriteLine(game.ToString());
                }
            }
            else
            {
                _userInteractor.PrintMessage("There is not results");
            }
        }
    }
}
