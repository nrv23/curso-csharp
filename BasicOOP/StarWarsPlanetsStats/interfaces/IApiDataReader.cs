namespace StarWarsPlanetsStats.interfaces;

public interface IApiDataReader
{
    Task<string> Read(string baseAddress, string requestUri);
}
