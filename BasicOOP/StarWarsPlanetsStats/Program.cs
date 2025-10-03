using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.clasess;
using StarWarsPlanetsStats.classes;




try
{
    await new StarWarsPlanetsStatsApp(
       new PlanetsReader(
            new APIDataReader(),
            new MockStarWarsApiDataReader()
         ),
       new PlanetsStatisticsAnalizer(
           new ConsoleUserInteractor()
           )
        ).Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}

Console.WriteLine("Pulsa una tecla para finalizar");

Console.ReadKey();

public partial class StarWarsPlanetsStatsApp
{
    private readonly PlanetsReader _planetsReader;
    private readonly IPlanetsStatisticsAnalizer _planetsStatisticsAnalizer;
    public StarWarsPlanetsStatsApp(PlanetsReader planetsReader, IPlanetsStatisticsAnalizer planetsStatisticsAnalizer)
    {
        _planetsReader = planetsReader;
        _planetsStatisticsAnalizer = planetsStatisticsAnalizer;
    }

    public async Task Run()
    {
        var planets = await _planetsReader.Read();
        TablePrinter.Print<Planet>(planets);
        Console.WriteLine();
        Console.WriteLine("Menu de estadisticas.");

        _planetsStatisticsAnalizer.Analyze(planets);
    }
}