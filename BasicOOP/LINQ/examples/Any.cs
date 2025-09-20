using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ.clasess;
using LINQ.interfaces;
namespace LINQ.examples
{
    public class Any
    {
        
        public bool IsLargerThan10(IEnumerable<int> numbers)
        {
            return numbers.Any(n => n > 10);
        }

        public bool IsAnyPetWithNameEd<T>(IEnumerable<T> pets) where T : INamed
        {
            return pets.Any(p => p.Name == "Ed");
        }

        public bool IsAnyFishInCollection(IEnumerable<Pet> pets) 
        {
            return pets.Any(p => p.PetType == PetType.Fish);
        }

        public bool IsVerySpecificPet(IEnumerable<Pet> pets) {

            return pets.Any(pet => pet.Name.Length > 6 && pet.Id % 2 == 0);
        }

        public bool IsCollectionNotEmpty<T>(IEnumerable<T> collection)
        {
            return collection.Any(); // Valida si la coleccion está vacia
        }

        public bool IsAnyWordWhiteSpace(IEnumerable<string> words)
        {
            return words.Any(word => string.IsNullOrWhiteSpace(word));
        }
    }
}
