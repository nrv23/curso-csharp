
namespace Dice_Roll_Game.clasess
{
    public static  class ConsoleReader
    {


        public static int ReadInteger(string v)
        {
            string userInput;
            int result;
            bool isValidNumber;
            do
            {
                Console.WriteLine(v);
                userInput = Console.ReadLine();
                isValidNumber = int.TryParse(userInput, out result);

            } while (!isValidNumber);

            return result;
        }
    }
}
