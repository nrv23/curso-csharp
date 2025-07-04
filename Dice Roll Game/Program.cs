
using Dice_Roll_Game.clasess;
using Dice_Roll_Game.classes;
using Dice_Roll_Game.utils;

var dice = new Dice(new Random());
var guessingGame = new GuessingGame(dice);

dice.Describe();
Console.WriteLine("Rolling a dice...");
GameResult gameResult = guessingGame.Play();
GuessingGame.PrintResultMessage(gameResult);
Console.ReadKey();

