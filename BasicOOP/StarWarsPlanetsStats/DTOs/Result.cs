
using System.Text.Json.Serialization; // para usar JsonPropertyName
namespace StarWarsPlanetsStats.DTOs; // indica el namespace

public record Result(
         // los records pueden mapear directamente a JSON
         // si la propiedad del JSON no es un identificador válido en C#, se puede usar JsonPropertyName para mapearlo
         // si es un identificador válido, no es necesario usar JsonPropertyName
         //[property: JsonPropertyName("name")] string name,
         string name,
        [property: JsonPropertyName("rotation_period")] string rotation_period,
        [property: JsonPropertyName("orbital_period")] string orbital_period,
        [property: JsonPropertyName("diameter")] string diameter,
        [property: JsonPropertyName("climate")] string climate,
        [property: JsonPropertyName("gravity")] string gravity,
        [property: JsonPropertyName("terrain")] string terrain,
        [property: JsonPropertyName("surface_water")] string surface_water,
        [property: JsonPropertyName("population")] string population,
        [property: JsonPropertyName("residents")] IReadOnlyList<string> residents,
        [property: JsonPropertyName("films")] IReadOnlyList<string> films,
        [property: JsonPropertyName("created")] DateTime created,
        [property: JsonPropertyName("edited")] DateTime edited,
        [property: JsonPropertyName("url")] string url
    );
