
namespace AdvancedTypes.clasess
{
    public interface IAPIDataReader
    {
        Task<string> ReadData(string baseUrl, string requestUrl);
    }
}