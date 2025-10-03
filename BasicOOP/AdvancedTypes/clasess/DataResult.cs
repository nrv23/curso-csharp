using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdvancedTypes.clasess
{
    public record Result(
       [property: JsonPropertyName("name")] string name,
       [property: JsonPropertyName("model")] string model,
       [property: JsonPropertyName("manufacturer")] string manufacturer,
       [property: JsonPropertyName("cost_in_credits")] string cost_in_credits,
       [property: JsonPropertyName("length")] string length,
       [property: JsonPropertyName("max_atmosphering_speed")] string max_atmosphering_speed,
       [property: JsonPropertyName("crew")] string crew,
       [property: JsonPropertyName("passengers")] string passengers,
       [property: JsonPropertyName("cargo_capacity")] string cargo_capacity,
       [property: JsonPropertyName("consumables")] string consumables,
       [property: JsonPropertyName("hyperdrive_rating")] string hyperdrive_rating,
       [property: JsonPropertyName("MGLT")] string MGLT,
       [property: JsonPropertyName("starship_class")] string starship_class,
       [property: JsonPropertyName("pilots")] IReadOnlyList<string> pilots,
       [property: JsonPropertyName("films")] IReadOnlyList<string> films,
       [property: JsonPropertyName("created")] DateTime created,
       [property: JsonPropertyName("edited")] DateTime edited,
       [property: JsonPropertyName("url")] string url
   );

    public record DataResult(
        [property: JsonPropertyName("count")] int count,
        [property: JsonPropertyName("next")] string next,
        [property: JsonPropertyName("previous")] object previous,
        [property: JsonPropertyName("results")] IReadOnlyList<Result> results
    );

}
