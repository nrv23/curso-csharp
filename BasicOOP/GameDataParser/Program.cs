using GameDataParser.clasess;


var logger = new Logger("log.txt");

try
{
     GameDataParserApp App = new GameDataParserApp(logger);
    App.Run();
}
catch(Exception ex)
{
    logger.Log(ex);
    Console.WriteLine("An error occurred. Please check the log file for details.");
}
finally
{
    Console.WriteLine("App will have to be closed...");
}

Console.ReadKey();