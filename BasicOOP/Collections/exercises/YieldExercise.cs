using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.exercises
{
    public class YieldExercise
    {
        public static IEnumerable<T> GetAllAfterLastNullReversed<T>(IList<T> input)
        {
            var indicesNulos = input
            .Select((valor, indice) => new { valor, indice })  // Asociar índice con valor
            .Where(x => x.valor == null)                       // Filtrar los nulos
            .Select(x => x.indice)                             // Obtener solo los índices
            .First();
           
        }
    }
}
