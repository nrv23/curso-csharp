
using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.classes;
using StarWarsPlanetsStats.DTOs;
using StarWarsPlanetsStats.interfaces;
using System.Text.Json;



try
{
    await new StarWarsPlanetsStatsApp(
       new APIDataReader(),
         new MockStarWarsApiDataReader()
        ).Run();
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}

Console.WriteLine("Pulsa una tecla para finalizar");

Console.ReadKey();


public static class StringExtensions
{
    public static int? ToIntOrNull(this string? value)
    {
        int? result = null;
        if (int.TryParse(value, out int intValue))
        {
            result = intValue;
        }
        return result;
    }
}

public class StarWarsPlanetsStatsApp
{
    const string ExpectedBaseAddress = "https://swapi.dev/";
    const string ExpectedRequestUri = "api/planets";
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondApiDataReader;

    public StarWarsPlanetsStatsApp(IApiDataReader apiDataReader, IApiDataReader secondApiDataReader)
    {
        _secondApiDataReader = secondApiDataReader;
        _apiDataReader = apiDataReader;
    }

    public async Task Run()
    {
        string? json = null;

        try
        {
            json = await _apiDataReader.Read(ExpectedBaseAddress, ExpectedRequestUri);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error al leer los datos de la API {ExpectedBaseAddress} : {ex.Message}. Cambiando a datos de prueba");
        }

        if (json is null)
        {
            json = await _secondApiDataReader.Read(ExpectedBaseAddress, ExpectedRequestUri);
        }

        var root = JsonSerializer.Deserialize<Root>(json);
        var planets = ToPlanets(root);
    }

    private IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root is null)
        {
            throw new ArgumentNullException($"{nameof(root)} is null");
        }

        var planets = new List<Planet>();

        foreach (var dto in root.results) // results es de tipo IReadOnlyList<Result>
        {
            Planet planet = (Planet)dto;
            planets.Add(planet);
        }

        return planets;
    }

    public readonly record struct Planet
    {
        public string Name { get; init; }
        public int Diameter { get; init; }
        public int? Population { get; init; }
        public int? SurfaceWater { get; init; }
        public Planet(string name, int diameter, int? population, int? surfaceWater)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("El nombre no puede ser nulo o vacío", nameof(name));
            }

            Name = name;
            Diameter = diameter;
            Population = population;
            SurfaceWater = surfaceWater;
        }
        // conversión explícita de Result a Planet
        public static explicit operator Planet(Result v) => new Planet(
            v.name,
            int.Parse(v.diameter),
            v.population.ToIntOrNull(),
            v.surface_water.ToIntOrNull()
        );
    }

   
}