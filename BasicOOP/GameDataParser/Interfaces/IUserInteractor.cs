using GameDataParser.clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDataParser.Interfaces
{
    public interface IUserInteractor
    {
        string ReadFilePathFromUser();
        void PrintMessage(string message);

        void PrintError(string errorMessage);
    }
}
