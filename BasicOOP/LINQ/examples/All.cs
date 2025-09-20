using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.clasess;
namespace LINQ.examples
{
    // All comprueba si todos los metodos de una coleccion cumplen con la condicion
    public class All
    {
        public bool AreAllNumbersLargerThan10<T>(IEnumerable<T> numbers) where T : Pet   
        {
            return numbers.All(n => n.Id > 10);
        }

        public bool AreAllNumbersLargerThan0<T>(IEnumerable<T> numbers) where T : Pet
        {
            return numbers.All(n => n.Id > 0);
        }

        public bool AreAllPetsCats<T>(IEnumerable<T> pets) where T : Pet
        {
            return pets.All(n => n.PetType == PetType.Cat);
        }

        public bool IsAllPetsHasNotEmptyNames<T>(IEnumerable<T> pets) where T : Pet
        {
            return pets.All(n => !string.IsNullOrEmpty(n.Name)); // comprueba que ningun nombre esté vacio
        }
    }
}
