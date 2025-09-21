using LINQ.clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public class Where
    {

        public IEnumerable<int> GetEventNumbers(IEnumerable<int> elements) 
        {
            return elements.Where(e => e % 2 == 0);
        }

        public IEnumerable<T> GetPetsHavierBetween10And100Kilos<T>(IEnumerable<T> elements) where T: Pet
        {
            return elements.Where(e => e.Weight >= 10 && e.Weight <= 100);
        }

        public IEnumerable<T> GetEspecificPets<T>(IEnumerable<T> elements) where T : Pet
        {
            // perros o gatos, nombre mayor a 4 letras , pesen mas de 10 kilos y tengan un ID par

            return elements.Where(e => (new List<PetType>() { PetType.Dog, PetType.Cat }).Contains(e.PetType)
                && e.Name.Length > 4 && e.Weight > 10 && (e.Id % 2 == 0));
        }

        public IEnumerable<T> GetPetsByIndexSelectedForTheUser<T>(IEnumerable<T> elements, int[] indexes) where T : Pet
        {
            return elements.Where((e, index) => e.Weight < 5 && indexes.Contains(index)); // index es el indice actual de 
            // la iteracion
        }
    }
}
