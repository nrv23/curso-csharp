
namespace Dice_Roll_Game.clasess
{

    
    public class Dice
    {

        private readonly Random _random;
        private const int SidesCount = 6;

        public Dice(Random random)
        {

            _random = random;
        }

        public int Roll() => _random.Next(1, SidesCount + 1);

        public void Describe() => Console.WriteLine($"It can roll a number between 1 and ${SidesCount}.");
           
    }
}
