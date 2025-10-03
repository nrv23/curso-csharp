using StarWarsPlanetsStats.DTOs;
using StarWarsPlanetsStats.interfaces;
using System.Text.Json;
using static StarWarsPlanetsStatsApp;

namespace StarWarsPlanetsStats.clasess; // indica el namespace
public class PlanetsReader : IPlanetsReader
{
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondApiDataReader;
    const string ExpectedBaseAddress = "https://swapi.dev/";
    const string ExpectedRequestUri = "api/planets";

    public PlanetsReader(IApiDataReader secondApiDataReader, IApiDataReader apiDataReader)
    {
        _secondApiDataReader = secondApiDataReader;
        _apiDataReader = apiDataReader;
    }

    public async Task<IEnumerable<Planet>> Read()
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
        //  si no se ha podido leer de la API, usar el lector de datos de prueba
        // ??= asignación null-coalescente
        // si json es null, asignarle el valor de la derecha y asignarlo a json, sino json se queda igual

        json ??= await _secondApiDataReader.Read(ExpectedBaseAddress, ExpectedRequestUri);


        var root = JsonSerializer.Deserialize<Root>(json);
        var planets = ToPlanets(root);
        // guardar aqui todas las opciones validas

        return planets;
    }

    private static IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root is null)
        {
            throw new ArgumentNullException($"{nameof(root)} is null");
        }
        var planets = root.results.Select(r => (Planet)r);
        return planets;
    }
}
public interface IPlanetsReader
{
    public Task<IEnumerable<Planet>> Read();
}   