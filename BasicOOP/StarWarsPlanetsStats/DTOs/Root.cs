using System.Text.Json.Serialization;
namespace StarWarsPlanetsStats.DTOs;

// usar records para mapear datos json y tener inmutabilidad
public record Root(
    [property: JsonPropertyName("count")] int count,
    [property: JsonPropertyName("next")] string next,
    [property: JsonPropertyName("previous")] object previous,
    [property: JsonPropertyName("results")] IReadOnlyList<Result> results
);