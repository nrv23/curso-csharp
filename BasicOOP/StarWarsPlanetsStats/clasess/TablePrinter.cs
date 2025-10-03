using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsPlanetsStats.clasess
{
    public static class TablePrinter
    {

        public static void Print<T>(IEnumerable<T> collection)
        {
            // obtener las propiedades de T usando reflexión
            const int columnWidth = 15;
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                Console.Write($"{{0,-{columnWidth}}}|", property.Name);
            }
            Console.WriteLine();

            Console.WriteLine(
                new string('-', properties.Length * (columnWidth + 1)));

            foreach (var element in collection) { 
                
                foreach(var propertie in properties)
                {
                    var value = propertie.GetValue(element);
                    Console.Write($"{{0,-{columnWidth}}}|", value);
                }
                Console.WriteLine();
            }
        }
    }
}
