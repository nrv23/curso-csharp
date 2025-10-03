using StarWarsPlanetsStats.DTOs;

public partial class StarWarsPlanetsStatsApp
{
    public readonly record struct Planet
    {
        public string Name { get; init; }
        public int Diameter { get; init; }
        public long? Population { get; init; }
        public int? SurfaceWater { get; init; }
        public Planet(string name, int diameter, long? population, int? surfaceWater)
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
            v.population.ToLongOrNull(),
            v.surface_water.ToIntOrNull()
        );
    }


}