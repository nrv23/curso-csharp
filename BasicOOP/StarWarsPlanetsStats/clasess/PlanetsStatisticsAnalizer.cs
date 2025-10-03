using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StarWarsPlanetsStats.DTOs;
using static StarWarsPlanetsStatsApp;

namespace StarWarsPlanetsStats.clasess
{
    public class PlanetsStatisticsAnalizer : IPlanetsStatisticsAnalizer
    {

        private readonly IUserInteractor _userInteractor;

        public PlanetsStatisticsAnalizer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }
        public void Analyze(IEnumerable<Planet> planets)
        {
            // long puede almancenar valores int y null sin ningun problema
            var propertiesNamesSelectorMapping = new Dictionary<string, Func<Planet, long?>>()
        {
            { "Population", p => p.Population },
            { "Diameter", p => p.Diameter },
            { "Surface Water", p => p.SurfaceWater }
        };

            foreach (var propertyName in propertiesNamesSelectorMapping.Keys)
            {
                Console.WriteLine(propertyName);
            }

            var userInput = _userInteractor.ReadFromUser();

            if (string.IsNullOrEmpty(userInput) || !propertiesNamesSelectorMapping.ContainsKey(userInput))
            {
                _userInteractor.ShowMessage($"{userInput} no es una opción valida");
            }
            else
            {
                ShowStatistics(planets, userInput!, propertiesNamesSelectorMapping[userInput!]);
            }
        }

        private static void ShowStatistics(IEnumerable<Planet> planets, string propertyName, Func<Planet, long?> propertySelector)
        {
            var planetWithMaxPropertyValue = planets.MaxBy(propertySelector);
            var planetWithMinPropertyValue = planets.MinBy(propertySelector);

            Console.WriteLine($"Planeta con mayor {propertyName}: {propertySelector(planetWithMaxPropertyValue)} con {propertySelector(planetWithMaxPropertyValue)}  ");
            Console.WriteLine($"Planeta con menor {propertyName}: {propertySelector(planetWithMinPropertyValue)} con {propertySelector(planetWithMinPropertyValue)} ");
        }
    }

    public interface IPlanetsStatisticsAnalizer
    {
        void Analyze(IEnumerable<Planet> planets);
    }
}
