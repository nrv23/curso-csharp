
public class Logger
{
    private string _logFileName { get; init; }
   
    public Logger(string _logFileName)
    {
        this._logFileName = _logFileName;
    }

    public void Log(Exception ex)
    {
        var logMessage = $@"
        [{DateTime.Now}]
        Exception Message: {ex.Message}
        Stack Trace: {ex.StackTrace}";

        File.AppendAllText(_logFileName, logMessage); // si el archivo no existe lo crea
    }
}