using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace AdvancedTypes.clasess
{
    public class APIDataReader : IAPIDataReader
    {
        public async Task<string> ReadData(string baseUrl, string requestUrl)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            var response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode(); // true si el status code es 200-299
            return await response.Content.ReadAsStringAsync(); // lee el contenido de la respuesta como string
        }
    }
}
