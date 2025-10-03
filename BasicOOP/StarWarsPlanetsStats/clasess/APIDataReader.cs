using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using StarWarsPlanetsStats.interfaces;

namespace StarWarsPlanetsStats.classes
{
    public class APIDataReader : IApiDataReader
    {
        public async Task<string> Read(string baseAddress, string requestUri)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            var response = await client.GetAsync(requestUri);
            response.EnsureSuccessStatusCode(); // true si el status code es 200-299
            return await response.Content.ReadAsStringAsync(); // lee el contenido de la respuesta como string
        }
    }
}
