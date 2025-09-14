using GameDataParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.clasess
{
    public class ConsoleUserInteractor : IUserInteractor
    {
       
        public string ReadFilePathFromUser()
        {

            bool isValidPath = false;
            string value;
            // devuelve el valor por defecto dependiendo del tipo de valor;
            do
            {

                PrintMessage("Enter the file name you want to read");
                value = Console.ReadLine();

                if (string.IsNullOrEmpty(value))
                {
                    PrintMessage("user input can not be empty or null");
                }
                else if (!File.Exists(value))
                {

                    PrintMessage($"{value} is not exists");
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

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintError(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintMessage(errorMessage);
            Console.ResetColor();
        }
    }
}
