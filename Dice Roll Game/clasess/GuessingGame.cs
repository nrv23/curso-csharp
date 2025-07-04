using Dice_Roll_Game.clasess;
using Dice_Roll_Game.utils;
using System;

namespace Dice_Roll_Game.classes
{
    public class GuessingGame
    {
        private readonly Dice _dice;
        private const int TotalAttempts = 3;

       

        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }

        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            GameResult result = GameResult.Loss;
            Console.WriteLine($"Dice Rolled. Guess what number it shows in {TotalAttempts} attempts.");

            var triesLeft = TotalAttempts;

            while (triesLeft > 0)
            {
                var guess = ConsoleReader.ReadInteger("Enter a number:");

                if (guess == diceRollResult)
                {
                    result = GameResult.Victory;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong number");
                }
                --triesLeft;
            }

            return result;
        }

        public static void PrintResultMessage(GameResult gameResult) => Console.WriteLine(gameResult == GameResult.Victory ? "You won!" : "You lost!");
    }
}
