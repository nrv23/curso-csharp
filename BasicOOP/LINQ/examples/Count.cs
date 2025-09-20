using LINQ.clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.examples
{
    public class Count
    {

        public int CountOfDogsInCollection<T>(IEnumerable<T> pets) where T : Pet
        {
            return pets.Count(p => p.PetType == PetType.Dog);
        }

        public long CountOfPetsWithIdLongerThan5<T>(IEnumerable<T> pets) where T: Pet
        {
            return pets.LongCount(p => p.Id > 5);
        } 

        public int CountOfAllSmallDogs<T>(IEnumerable<T> pets) where T : Pet
        {
            return pets.Count(pet =>
            {
                return pet.PetType == PetType.Dog
                && pet.Weight < 10;
            });
        }

        public int CountListsContainingZeroLongerThan(int length, List<List<int>> listsOfNumbers) => 
            listsOfNumbers.Where( list => list.Contains(0) && list.Count > length ).Count();
        
    }
}
