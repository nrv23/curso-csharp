using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetsStats.clasess
{
    public class ConsoleUserInteractor: IUserInteractor
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public string? ReadFromUser()
        {
            return Console.ReadLine();
        }
    }
  
    public interface IUserInteractor
    {
        // definir los métodos que se van a usar para interactuar con el usuario
        void ShowMessage(string message);
        string? ReadFromUser();
    }
}
